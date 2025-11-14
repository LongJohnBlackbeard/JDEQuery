using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T50 - .
/// </summary>
public class F49T50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LOORDNUMID.
        /// </summary>
        public const string LOORDNUMID = "LOORDNUMID";

        /// <summary>
        /// LOOTORDRLS.
        /// </summary>
        public const string LOOTORDRLS = "LOOTORDRLS";

        /// <summary>
        /// LOAN8.
        /// </summary>
        public const string LOAN8 = "LOAN8";

        /// <summary>
        /// LOOTLOCDOM.
        /// </summary>
        public const string LOOTLOCDOM = "LOOTLOCDOM";

        /// <summary>
        /// LOOTTRNCOD.
        /// </summary>
        public const string LOOTTRNCOD = "LOOTTRNCOD";

        /// <summary>
        /// LOOTLOCROL.
        /// </summary>
        public const string LOOTLOCROL = "LOOTLOCROL";

        /// <summary>
        /// LOPA8.
        /// </summary>
        public const string LOPA8 = "LOPA8";

        /// <summary>
        /// LOSPATTN.
        /// </summary>
        public const string LOSPATTN = "LOSPATTN";

        /// <summary>
        /// LOALPH.
        /// </summary>
        public const string LOALPH = "LOALPH";

        /// <summary>
        /// LOADD1.
        /// </summary>
        public const string LOADD1 = "LOADD1";

        /// <summary>
        /// LOOTADDSQ1.
        /// </summary>
        public const string LOOTADDSQ1 = "LOOTADDSQ1";

        /// <summary>
        /// LOADD2.
        /// </summary>
        public const string LOADD2 = "LOADD2";

        /// <summary>
        /// LOOTADDSQ2.
        /// </summary>
        public const string LOOTADDSQ2 = "LOOTADDSQ2";

        /// <summary>
        /// LOADD3.
        /// </summary>
        public const string LOADD3 = "LOADD3";

        /// <summary>
        /// LOOTADDSQ3.
        /// </summary>
        public const string LOOTADDSQ3 = "LOOTADDSQ3";

        /// <summary>
        /// LOADD4.
        /// </summary>
        public const string LOADD4 = "LOADD4";

        /// <summary>
        /// LOOTADDSQ4.
        /// </summary>
        public const string LOOTADDSQ4 = "LOOTADDSQ4";

        /// <summary>
        /// LOCTY1.
        /// </summary>
        public const string LOCTY1 = "LOCTY1";

        /// <summary>
        /// LOADDS.
        /// </summary>
        public const string LOADDS = "LOADDS";

        /// <summary>
        /// LOADDZ.
        /// </summary>
        public const string LOADDZ = "LOADDZ";

        /// <summary>
        /// LOCTR.
        /// </summary>
        public const string LOCTR = "LOCTR";

        /// <summary>
        /// LOCOUN.
        /// </summary>
        public const string LOCOUN = "LOCOUN";

        /// <summary>
        /// LOZON.
        /// </summary>
        public const string LOZON = "LOZON";

        /// <summary>
        /// LOMCU.
        /// </summary>
        public const string LOMCU = "LOMCU";

        /// <summary>
        /// LOURCD.
        /// </summary>
        public const string LOURCD = "LOURCD";

        /// <summary>
        /// LOURDT.
        /// </summary>
        public const string LOURDT = "LOURDT";

        /// <summary>
        /// LOURRF.
        /// </summary>
        public const string LOURRF = "LOURRF";

        /// <summary>
        /// LOURAT.
        /// </summary>
        public const string LOURAT = "LOURAT";

        /// <summary>
        /// LOURAB.
        /// </summary>
        public const string LOURAB = "LOURAB";

        /// <summary>
        /// LOUSER.
        /// </summary>
        public const string LOUSER = "LOUSER";

        /// <summary>
        /// LOPID.
        /// </summary>
        public const string LOPID = "LOPID";

        /// <summary>
        /// LOTORG.
        /// </summary>
        public const string LOTORG = "LOTORG";

        /// <summary>
        /// LOJOBN.
        /// </summary>
        public const string LOJOBN = "LOJOBN";

        /// <summary>
        /// LOUUPMJ.
        /// </summary>
        public const string LOUUPMJ = "LOUUPMJ";

        /// <summary>
        /// LOALPH1.
        /// </summary>
        public const string LOALPH1 = "LOALPH1";

        /// <summary>
        /// LOCO.
        /// </summary>
        public const string LOCO = "LOCO";

        /// <summary>
        /// LOCRDC.
        /// </summary>
        public const string LOCRDC = "LOCRDC";

        /// <summary>
        /// LOOTE1REF1.
        /// </summary>
        public const string LOOTE1REF1 = "LOOTE1REF1";

        /// <summary>
        /// LOOTE1REF2.
        /// </summary>
        public const string LOOTE1REF2 = "LOOTE1REF2";

        /// <summary>
        /// LOOTE1REF3.
        /// </summary>
        public const string LOOTE1REF3 = "LOOTE1REF3";

        /// <summary>
        /// LOOTCHAR1.
        /// </summary>
        public const string LOOTCHAR1 = "LOOTCHAR1";

        /// <summary>
        /// LOOTCHAR2.
        /// </summary>
        public const string LOOTCHAR2 = "LOOTCHAR2";

        /// <summary>
        /// LOOTCHAR3.
        /// </summary>
        public const string LOOTCHAR3 = "LOOTCHAR3";

        /// <summary>
        /// LOOTMATH1.
        /// </summary>
        public const string LOOTMATH1 = "LOOTMATH1";

        /// <summary>
        /// LOOTMATH2.
        /// </summary>
        public const string LOOTMATH2 = "LOOTMATH2";

        /// <summary>
        /// LOOTMATH3.
        /// </summary>
        public const string LOOTMATH3 = "LOOTMATH3";
    }

    /// <inheritdoc />
    public override string TableName => "F49T50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LOORDNUMID", "LOORDNUMID", JdeDataType.String, 60, true, true),
        new JdeField("LOOTORDRLS", "LOOTORDRLS", JdeDataType.String, 100, true, true),
        new JdeField("LOAN8", "LOAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LOOTLOCDOM", "LOOTLOCDOM", JdeDataType.String, 100),
        new JdeField("LOOTTRNCOD", "LOOTTRNCOD", JdeDataType.String, 4),
        new JdeField("LOOTLOCROL", "LOOTLOCROL", JdeDataType.String, 100),
        new JdeField("LOPA8", "LOPA8", JdeDataType.Numeric),
        new JdeField("LOSPATTN", "LOSPATTN", JdeDataType.String, 100),
        new JdeField("LOALPH", "LOALPH", JdeDataType.String, 80),
        new JdeField("LOADD1", "LOADD1", JdeDataType.String, 80),
        new JdeField("LOOTADDSQ1", "LOOTADDSQ1", JdeDataType.Numeric),
        new JdeField("LOADD2", "LOADD2", JdeDataType.String, 80),
        new JdeField("LOOTADDSQ2", "LOOTADDSQ2", JdeDataType.Numeric),
        new JdeField("LOADD3", "LOADD3", JdeDataType.String, 80),
        new JdeField("LOOTADDSQ3", "LOOTADDSQ3", JdeDataType.Numeric),
        new JdeField("LOADD4", "LOADD4", JdeDataType.String, 80),
        new JdeField("LOOTADDSQ4", "LOOTADDSQ4", JdeDataType.Numeric),
        new JdeField("LOCTY1", "LOCTY1", JdeDataType.String, 50),
        new JdeField("LOADDS", "LOADDS", JdeDataType.String, 6),
        new JdeField("LOADDZ", "LOADDZ", JdeDataType.String, 24),
        new JdeField("LOCTR", "LOCTR", JdeDataType.String, 6),
        new JdeField("LOCOUN", "LOCOUN", JdeDataType.String, 50),
        new JdeField("LOZON", "LOZON", JdeDataType.String, 6),
        new JdeField("LOMCU", "LOMCU", JdeDataType.String, 24),
        new JdeField("LOURCD", "LOURCD", JdeDataType.String, 4),
        new JdeField("LOURDT", "LOURDT", JdeDataType.Numeric),
        new JdeField("LOURRF", "LOURRF", JdeDataType.String, 30),
        new JdeField("LOURAT", "LOURAT", JdeDataType.Numeric),
        new JdeField("LOURAB", "LOURAB", JdeDataType.Numeric),
        new JdeField("LOUSER", "LOUSER", JdeDataType.String, 20),
        new JdeField("LOPID", "LOPID", JdeDataType.String, 20),
        new JdeField("LOTORG", "LOTORG", JdeDataType.String, 20),
        new JdeField("LOJOBN", "LOJOBN", JdeDataType.String, 20),
        new JdeField("LOUUPMJ", "LOUUPMJ", JdeDataType.Date),
        new JdeField("LOALPH1", "LOALPH1", JdeDataType.String, 80),
        new JdeField("LOCO", "LOCO", JdeDataType.String, 10),
        new JdeField("LOCRDC", "LOCRDC", JdeDataType.String, 6),
        new JdeField("LOOTE1REF1", "LOOTE1REF1", JdeDataType.String, 100),
        new JdeField("LOOTE1REF2", "LOOTE1REF2", JdeDataType.String, 100),
        new JdeField("LOOTE1REF3", "LOOTE1REF3", JdeDataType.String, 100),
        new JdeField("LOOTCHAR1", "LOOTCHAR1", JdeDataType.String, 2),
        new JdeField("LOOTCHAR2", "LOOTCHAR2", JdeDataType.String, 2),
        new JdeField("LOOTCHAR3", "LOOTCHAR3", JdeDataType.String, 2),
        new JdeField("LOOTMATH1", "LOOTMATH1", JdeDataType.Numeric),
        new JdeField("LOOTMATH2", "LOOTMATH2", JdeDataType.Numeric),
        new JdeField("LOOTMATH3", "LOOTMATH3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T50_0", "Primary Key on LOORDNUMID, LOOTORDRLS, LOAN8", new[] { "LOORDNUMID", "LOOTORDRLS", "LOAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T50_2", "Index on LOOTORDRLS", new[] { "LOOTORDRLS" })
    };
}
