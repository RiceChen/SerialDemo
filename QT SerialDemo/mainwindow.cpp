#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    setWindowTitle(tr("QT Serial-<Rice DIY> Wechat:wueroo1314"));
    ui->radioButton->setEnabled(false);
    connect(ui->pushButton_2,SIGNAL(clicked(bool)),this,SLOT(openOrCloseBtn()));
    //信号和槽函数关联，当按键按下时，进行串口打开关闭操作
    connect(ui->pushButton,SIGNAL(clicked(bool)),this,SLOT(sendMsgBtn()));
    //信号和槽函数关联，当按键按下时，进行数据发送操作
    flag=false;
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::openOrCloseBtn()
{
    if(flag==false)
    {
        QString portName=ui->comboBox->currentText();
        myCom=new Win_QextSerialPort(portName,QextSerialBase::EventDriven);
        myCom->open(QIODevice::ReadWrite);

        //设置波特率
        if(ui->comboBox_2->currentText()==tr("9600"))
            myCom->setBaudRate(BAUD9600);
        else if(ui->comboBox_2->currentText()==tr("115200"))
            myCom->setBaudRate(BAUD115200);
        //设置奇偶校验位
        if(ui->comboBox_3->currentText()==QStringLiteral("无"))
            myCom->setParity(PAR_NONE);
        else if(ui->comboBox_3->currentText()==QStringLiteral("奇"))
            myCom->setParity(PAR_ODD);
        else if(ui->comboBox_3->currentText()==QStringLiteral("偶"))
            myCom->setParity(PAR_EVEN);
        //设置数据位
        if(ui->comboBox_4->currentText()==tr("8"))
            myCom->setDataBits(DATA_8);
        else if(ui->comboBox_4->currentText()==tr("7"))
            myCom->setDataBits(DATA_7);
        //设置停止位
        if(ui->comboBox_5->currentText()==tr("1"))
            myCom->setStopBits(STOP_1);
        else if(ui->comboBox_5->currentText()==tr("2"))
            myCom->setStopBits(STOP_2);

        myCom->setFlowControl(FLOW_OFF);//设置数据流控制，我们使用无数据流控制的默认设置
        myCom->setTimeout(500); //设置延时
        connect(myCom,SIGNAL(readyRead()),this,SLOT(readMyCom()));
        //信号和槽函数关联，当串口缓冲区有数据时，进行读串口操作
        ui->pushButton_2->setText(tr("关闭串口"));
        ui->radioButton->setChecked(true);
        ui->comboBox->setEnabled(false);
        ui->comboBox_2->setEnabled(false);
        ui->comboBox_3->setEnabled(false);
        ui->comboBox_4->setEnabled(false);
        ui->comboBox_5->setEnabled(false);
        flag=true;
    }
    else
    {
        myCom->close();
        ui->pushButton_2->setText(tr("打开串口"));
        ui->radioButton->setChecked(false);
        ui->comboBox->setEnabled(true);
        ui->comboBox_2->setEnabled(true);
        ui->comboBox_3->setEnabled(true);
        ui->comboBox_4->setEnabled(true);
        ui->comboBox_5->setEnabled(true);
        flag=false;
    }
}

//读串口
void MainWindow::readMyCom()
{
    QByteArray temp = myCom->readAll();
    ui->textBrowser->insertPlainText(temp);
}

//写串口
void MainWindow::sendMsgBtn()
{
    myCom->write(ui->lineEdit->text().toLatin1());
}
