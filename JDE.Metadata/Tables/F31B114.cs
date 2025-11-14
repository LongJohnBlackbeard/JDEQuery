using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B114 - .
/// </summary>
public class F31B114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TBWTBID.
        /// </summary>
        public const string TBWTBID = "TBWTBID";

        /// <summary>
        /// TBWTBNAME.
        /// </summary>
        public const string TBWTBNAME = "TBWTBNAME";

        /// <summary>
        /// TBWTBDESC.
        /// </summary>
        public const string TBWTBDESC = "TBWTBDESC";

        /// <summary>
        /// TBMCU.
        /// </summary>
        public const string TBMCU = "TBMCU";

        /// <summary>
        /// TBWTBST.
        /// </summary>
        public const string TBWTBST = "TBWTBST";

        /// <summary>
        /// TBWDCJ.
        /// </summary>
        public const string TBWDCJ = "TBWDCJ";

        /// <summary>
        /// TBWTBAN8.
        /// </summary>
        public const string TBWTBAN8 = "TBWTBAN8";

        /// <summary>
        /// TBNCPATHID.
        /// </summary>
        public const string TBNCPATHID = "TBNCPATHID";

        /// <summary>
        /// TBWTBSCT.
        /// </summary>
        public const string TBWTBSCT = "TBWTBSCT";

        /// <summary>
        /// TBEURID.
        /// </summary>
        public const string TBEURID = "TBEURID";

        /// <summary>
        /// TBWTBQTY.
        /// </summary>
        public const string TBWTBQTY = "TBWTBQTY";

        /// <summary>
        /// TBWVSPID.
        /// </summary>
        public const string TBWVSPID = "TBWVSPID";

        /// <summary>
        /// TBWTBWS.
        /// </summary>
        public const string TBWTBWS = "TBWTBWS";

        /// <summary>
        /// TBWBBVOL.
        /// </summary>
        public const string TBWBBVOL = "TBWBBVOL";

        /// <summary>
        /// TBWBBUOM.
        /// </summary>
        public const string TBWBBUOM = "TBWBBUOM";

        /// <summary>
        /// TBWTBCAT1.
        /// </summary>
        public const string TBWTBCAT1 = "TBWTBCAT1";

        /// <summary>
        /// TBWTBCAT2.
        /// </summary>
        public const string TBWTBCAT2 = "TBWTBCAT2";

        /// <summary>
        /// TBWTBCAT3.
        /// </summary>
        public const string TBWTBCAT3 = "TBWTBCAT3";

        /// <summary>
        /// TBWTBCAT4.
        /// </summary>
        public const string TBWTBCAT4 = "TBWTBCAT4";

        /// <summary>
        /// TBWTBCAT5.
        /// </summary>
        public const string TBWTBCAT5 = "TBWTBCAT5";

        /// <summary>
        /// TBWTBLSTD.
        /// </summary>
        public const string TBWTBLSTD = "TBWTBLSTD";

        /// <summary>
        /// TBURAB.
        /// </summary>
        public const string TBURAB = "TBURAB";

        /// <summary>
        /// TBURAT.
        /// </summary>
        public const string TBURAT = "TBURAT";

        /// <summary>
        /// TBURCD.
        /// </summary>
        public const string TBURCD = "TBURCD";

        /// <summary>
        /// TBURDT.
        /// </summary>
        public const string TBURDT = "TBURDT";

        /// <summary>
        /// TBURRF.
        /// </summary>
        public const string TBURRF = "TBURRF";

        /// <summary>
        /// TBWAB.
        /// </summary>
        public const string TBWAB = "TBWAB";

        /// <summary>
        /// TBWNUM.
        /// </summary>
        public const string TBWNUM = "TBWNUM";

        /// <summary>
        /// TBWCD.
        /// </summary>
        public const string TBWCD = "TBWCD";

        /// <summary>
        /// TBWMDT.
        /// </summary>
        public const string TBWMDT = "TBWMDT";

        /// <summary>
        /// TBWRF.
        /// </summary>
        public const string TBWRF = "TBWRF";

        /// <summary>
        /// TBUSER.
        /// </summary>
        public const string TBUSER = "TBUSER";

        /// <summary>
        /// TBUPMJ.
        /// </summary>
        public const string TBUPMJ = "TBUPMJ";

        /// <summary>
        /// TBUPMT.
        /// </summary>
        public const string TBUPMT = "TBUPMT";

        /// <summary>
        /// TBJOBN.
        /// </summary>
        public const string TBJOBN = "TBJOBN";

        /// <summary>
        /// TBMKEY.
        /// </summary>
        public const string TBMKEY = "TBMKEY";

        /// <summary>
        /// TBPID.
        /// </summary>
        public const string TBPID = "TBPID";

        /// <summary>
        /// TBWTBDBMET.
        /// </summary>
        public const string TBWTBDBMET = "TBWTBDBMET";

        /// <summary>
        /// TBBNCHID.
        /// </summary>
        public const string TBBNCHID = "TBBNCHID";

        /// <summary>
        /// TBUSRQDT.
        /// </summary>
        public const string TBUSRQDT = "TBUSRQDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TBWTBID", "TBWTBID", JdeDataType.Numeric, null, true, true),
        new JdeField("TBWTBNAME", "TBWTBNAME", JdeDataType.String, 60),
        new JdeField("TBWTBDESC", "TBWTBDESC", JdeDataType.String, 60),
        new JdeField("TBMCU", "TBMCU", JdeDataType.String, 24),
        new JdeField("TBWTBST", "TBWTBST", JdeDataType.String, 2),
        new JdeField("TBWDCJ", "TBWDCJ", JdeDataType.Numeric),
        new JdeField("TBWTBAN8", "TBWTBAN8", JdeDataType.Numeric),
        new JdeField("TBNCPATHID", "TBNCPATHID", JdeDataType.Numeric),
        new JdeField("TBWTBSCT", "TBWTBSCT", JdeDataType.Numeric),
        new JdeField("TBEURID", "TBEURID", JdeDataType.Numeric),
        new JdeField("TBWTBQTY", "TBWTBQTY", JdeDataType.Numeric),
        new JdeField("TBWVSPID", "TBWVSPID", JdeDataType.Numeric),
        new JdeField("TBWTBWS", "TBWTBWS", JdeDataType.String, 12),
        new JdeField("TBWBBVOL", "TBWBBVOL", JdeDataType.Numeric),
        new JdeField("TBWBBUOM", "TBWBBUOM", JdeDataType.String, 4),
        new JdeField("TBWTBCAT1", "TBWTBCAT1", JdeDataType.String, 20),
        new JdeField("TBWTBCAT2", "TBWTBCAT2", JdeDataType.String, 20),
        new JdeField("TBWTBCAT3", "TBWTBCAT3", JdeDataType.String, 20),
        new JdeField("TBWTBCAT4", "TBWTBCAT4", JdeDataType.String, 20),
        new JdeField("TBWTBCAT5", "TBWTBCAT5", JdeDataType.String, 20),
        new JdeField("TBWTBLSTD", "TBWTBLSTD", JdeDataType.Numeric),
        new JdeField("TBURAB", "TBURAB", JdeDataType.Numeric),
        new JdeField("TBURAT", "TBURAT", JdeDataType.Numeric),
        new JdeField("TBURCD", "TBURCD", JdeDataType.String, 4),
        new JdeField("TBURDT", "TBURDT", JdeDataType.Numeric),
        new JdeField("TBURRF", "TBURRF", JdeDataType.String, 30),
        new JdeField("TBWAB", "TBWAB", JdeDataType.Numeric),
        new JdeField("TBWNUM", "TBWNUM", JdeDataType.Numeric),
        new JdeField("TBWCD", "TBWCD", JdeDataType.String, 6),
        new JdeField("TBWMDT", "TBWMDT", JdeDataType.Numeric),
        new JdeField("TBWRF", "TBWRF", JdeDataType.String, 60),
        new JdeField("TBUSER", "TBUSER", JdeDataType.String, 20),
        new JdeField("TBUPMJ", "TBUPMJ", JdeDataType.Numeric),
        new JdeField("TBUPMT", "TBUPMT", JdeDataType.Numeric),
        new JdeField("TBJOBN", "TBJOBN", JdeDataType.String, 20),
        new JdeField("TBMKEY", "TBMKEY", JdeDataType.String, 30),
        new JdeField("TBPID", "TBPID", JdeDataType.String, 20),
        new JdeField("TBWTBDBMET", "TBWTBDBMET", JdeDataType.String, 20),
        new JdeField("TBBNCHID", "TBBNCHID", JdeDataType.Numeric),
        new JdeField("TBUSRQDT", "TBUSRQDT", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B114_0", "Primary Key on TBWTBID", new[] { "TBWTBID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B114_2", "Unique Index on TBWTBNAME", new[] { "TBWTBNAME" }, isUnique: true)
    };
}
