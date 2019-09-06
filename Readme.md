# BarCode Checker

## 功能
檢測掃描的資料是否重複

## 開發需求
1. Visual Studio 2019 Express
2. Windows 10
3. MSSQL 2017 express (enable 1433 tcp)

## 安裝需求(用戶端)
1. .Net Framework 4.0
2. Windows 7 以上

## 安裝需求(MSSQL服務器端)
建立資料表,MSSQL(建議2017以上)
```
CREATE TABLE [BAR_CODE_SCAN_HISTORY]
(
    [UID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY , 
    [WORKSTATION_NUMBER] NVARCHAR(50) NULL, 
    [SN] NVARCHAR(50) NULL, 
    [LOG] NVARCHAR(50) NULL, 
    [STATUS] NVARCHAR(50) NULL, 
    [MEMO] NVARCHAR(50) NULL, 
    CONSTRAINT [UNIQUE_SN] UNIQUE (WORKSTATION_NUMBER,SN,STATUS,MEMO)
)
GO
CREATE INDEX [INDEX_SN] ON [dbo].[BAR_CODE_SCAN_HISTORY] (SN)
GO
CREATE INDEX [INDEX_STATUS] ON [dbo].[BAR_CODE_SCAN_HISTORY] (STATUS)
GO
```
## 執行注意事項
1. 設定相關參數,開啟密碼預設為kafeiou
2. 請務必設定好資料庫IP,資料庫名稱,登入帳號與密碼等等)

## 開發者
https://kafeiou.pw
william
