using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B0741 - .
/// </summary>
public class F31B0741 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCEURID.
        /// </summary>
        public const string CCEURID = "CCEURID";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCACTIVITY.
        /// </summary>
        public const string CCACTIVITY = "CCACTIVITY";

        /// <summary>
        /// CCPLNTYP.
        /// </summary>
        public const string CCPLNTYP = "CCPLNTYP";

        /// <summary>
        /// CCCEURID.
        /// </summary>
        public const string CCCEURID = "CCCEURID";

        /// <summary>
        /// CCCIOF.
        /// </summary>
        public const string CCCIOF = "CCCIOF";

        /// <summary>
        /// CCCPCNT.
        /// </summary>
        public const string CCCPCNT = "CCCPCNT";

        /// <summary>
        /// CCCULLVOL.
        /// </summary>
        public const string CCCULLVOL = "CCCULLVOL";

        /// <summary>
        /// CCURCD.
        /// </summary>
        public const string CCURCD = "CCURCD";

        /// <summary>
        /// CCURDT.
        /// </summary>
        public const string CCURDT = "CCURDT";

        /// <summary>
        /// CCURRF.
        /// </summary>
        public const string CCURRF = "CCURRF";

        /// <summary>
        /// CCURAB.
        /// </summary>
        public const string CCURAB = "CCURAB";

        /// <summary>
        /// CCWRF.
        /// </summary>
        public const string CCWRF = "CCWRF";

        /// <summary>
        /// CCWCD.
        /// </summary>
        public const string CCWCD = "CCWCD";

        /// <summary>
        /// CCWAB.
        /// </summary>
        public const string CCWAB = "CCWAB";

        /// <summary>
        /// CCWNUM.
        /// </summary>
        public const string CCWNUM = "CCWNUM";

        /// <summary>
        /// CCWMDT.
        /// </summary>
        public const string CCWMDT = "CCWMDT";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F31B0741";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCEURID", "CCEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCACTIVITY", "CCACTIVITY", JdeDataType.String, 20, true, true),
        new JdeField("CCPLNTYP", "CCPLNTYP", JdeDataType.String, 2, true, true),
        new JdeField("CCCEURID", "CCCEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCIOF", "CCCIOF", JdeDataType.String, 2),
        new JdeField("CCCPCNT", "CCCPCNT", JdeDataType.Numeric),
        new JdeField("CCCULLVOL", "CCCULLVOL", JdeDataType.Numeric),
        new JdeField("CCURCD", "CCURCD", JdeDataType.String, 4),
        new JdeField("CCURDT", "CCURDT", JdeDataType.Numeric),
        new JdeField("CCURRF", "CCURRF", JdeDataType.String, 30),
        new JdeField("CCURAB", "CCURAB", JdeDataType.Numeric),
        new JdeField("CCWRF", "CCWRF", JdeDataType.String, 60),
        new JdeField("CCWCD", "CCWCD", JdeDataType.String, 6),
        new JdeField("CCWAB", "CCWAB", JdeDataType.Numeric),
        new JdeField("CCWNUM", "CCWNUM", JdeDataType.Numeric),
        new JdeField("CCWMDT", "CCWMDT", JdeDataType.Numeric),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B0741_0", "Primary Key on CCEURID, CCMCU, CCACTIVITY, CCPLNTYP, CCCEURID", new[] { "CCEURID", "CCMCU", "CCACTIVITY", "CCPLNTYP", "CCCEURID" }, isUnique: true, isPrimaryKey: true)
    };
}
