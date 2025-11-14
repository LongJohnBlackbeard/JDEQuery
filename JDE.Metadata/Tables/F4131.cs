using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4131 - .
/// </summary>
public class F4131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDCHNO.
        /// </summary>
        public const string MDCHNO = "MDCHNO";

        /// <summary>
        /// MDCDNO.
        /// </summary>
        public const string MDCDNO = "MDCDNO";

        /// <summary>
        /// MDITM.
        /// </summary>
        public const string MDITM = "MDITM";

        /// <summary>
        /// MDCBYLOT.
        /// </summary>
        public const string MDCBYLOT = "MDCBYLOT";

        /// <summary>
        /// MDCSQTY.
        /// </summary>
        public const string MDCSQTY = "MDCSQTY";

        /// <summary>
        /// MDREPLTY.
        /// </summary>
        public const string MDREPLTY = "MDREPLTY";

        /// <summary>
        /// MDCROQ.
        /// </summary>
        public const string MDCROQ = "MDCROQ";

        /// <summary>
        /// MDCROP.
        /// </summary>
        public const string MDCROP = "MDCROP";

        /// <summary>
        /// MDASN.
        /// </summary>
        public const string MDASN = "MDASN";

        /// <summary>
        /// MDUOM.
        /// </summary>
        public const string MDUOM = "MDUOM";

        /// <summary>
        /// MDUOM2.
        /// </summary>
        public const string MDUOM2 = "MDUOM2";

        /// <summary>
        /// MDCSAAN8.
        /// </summary>
        public const string MDCSAAN8 = "MDCSAAN8";

        /// <summary>
        /// MDSTRDTJ.
        /// </summary>
        public const string MDSTRDTJ = "MDSTRDTJ";

        /// <summary>
        /// MDENDDTJ.
        /// </summary>
        public const string MDENDDTJ = "MDENDDTJ";

        /// <summary>
        /// MDURCD.
        /// </summary>
        public const string MDURCD = "MDURCD";

        /// <summary>
        /// MDURDT.
        /// </summary>
        public const string MDURDT = "MDURDT";

        /// <summary>
        /// MDURAT.
        /// </summary>
        public const string MDURAT = "MDURAT";

        /// <summary>
        /// MDURAB.
        /// </summary>
        public const string MDURAB = "MDURAB";

        /// <summary>
        /// MDURRF.
        /// </summary>
        public const string MDURRF = "MDURRF";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDMKEY.
        /// </summary>
        public const string MDMKEY = "MDMKEY";

        /// <summary>
        /// MDUTIME.
        /// </summary>
        public const string MDUTIME = "MDUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDCHNO", "MDCHNO", JdeDataType.Numeric, null, true, true),
        new JdeField("MDCDNO", "MDCDNO", JdeDataType.Numeric, null, true, true),
        new JdeField("MDITM", "MDITM", JdeDataType.Numeric),
        new JdeField("MDCBYLOT", "MDCBYLOT", JdeDataType.String, 2),
        new JdeField("MDCSQTY", "MDCSQTY", JdeDataType.Numeric),
        new JdeField("MDREPLTY", "MDREPLTY", JdeDataType.String, 2),
        new JdeField("MDCROQ", "MDCROQ", JdeDataType.Numeric),
        new JdeField("MDCROP", "MDCROP", JdeDataType.Numeric),
        new JdeField("MDASN", "MDASN", JdeDataType.String, 16),
        new JdeField("MDUOM", "MDUOM", JdeDataType.String, 4),
        new JdeField("MDUOM2", "MDUOM2", JdeDataType.String, 4),
        new JdeField("MDCSAAN8", "MDCSAAN8", JdeDataType.Numeric),
        new JdeField("MDSTRDTJ", "MDSTRDTJ", JdeDataType.Numeric),
        new JdeField("MDENDDTJ", "MDENDDTJ", JdeDataType.Numeric),
        new JdeField("MDURCD", "MDURCD", JdeDataType.String, 4),
        new JdeField("MDURDT", "MDURDT", JdeDataType.Numeric),
        new JdeField("MDURAT", "MDURAT", JdeDataType.Numeric),
        new JdeField("MDURAB", "MDURAB", JdeDataType.Numeric),
        new JdeField("MDURRF", "MDURRF", JdeDataType.String, 30),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDMKEY", "MDMKEY", JdeDataType.String, 30),
        new JdeField("MDUTIME", "MDUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4131_0", "Primary Key on MDCHNO, MDCDNO", new[] { "MDCHNO", "MDCDNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4131_2", "Index on MDCHNO", new[] { "MDCHNO" })
    };
}
