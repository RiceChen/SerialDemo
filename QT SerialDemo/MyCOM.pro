#-------------------------------------------------
#
# Project created by QtCreator 2018-03-20T12:39:45
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = MyCOM
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    qextserialbase.cpp \
    qextserialport.cpp \
    win_qextserialport.cpp

HEADERS  += mainwindow.h \
    qextserialbase.h \
    qextserialport.h \
    win_qextserialport.h

FORMS    += mainwindow.ui
