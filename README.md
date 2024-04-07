# CalculatorApp

## 機能一覧
- 四則演算
- 戻る
- 進む
- クリア
- ログ出力
- 履歴の記録

## サンプルデータベース
```sql
CREATE DATABASE historyDB;
GO

USE historyDB;
GO

CREATE TABLE history (
    id INT IDENTITY(1,1) PRIMARY KEY,
    operation NVARCHAR(MAX),
    result NVARCHAR(MAX)
);
GO
```