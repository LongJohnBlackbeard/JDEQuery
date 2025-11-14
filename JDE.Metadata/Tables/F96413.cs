using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F96413 - .
/// </summary>
public class F96413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTUSER1.
        /// </summary>
        public const string DTUSER1 = "DTUSER1";

        /// <summary>
        /// DTDATE01.
        /// </summary>
        public const string DTDATE01 = "DTDATE01";

        /// <summary>
        /// DTTME0.
        /// </summary>
        public const string DTTME0 = "DTTME0";

        /// <summary>
        /// DTOMWPRJID.
        /// </summary>
        public const string DTOMWPRJID = "DTOMWPRJID";

        /// <summary>
        /// DTPOBJNM.
        /// </summary>
        public const string DTPOBJNM = "DTPOBJNM";

        /// <summary>
        /// DTDOBJNM.
        /// </summary>
        public const string DTDOBJNM = "DTDOBJNM";

        /// <summary>
        /// DTESUP.
        /// </summary>
        public const string DTESUP = "DTESUP";

        /// <summary>
        /// DTSUCOUNT.
        /// </summary>
        public const string DTSUCOUNT = "DTSUCOUNT";

        /// <summary>
        /// DTDEPTYPE.
        /// </summary>
        public const string DTDEPTYPE = "DTDEPTYPE";

        /// <summary>
        /// DTREM1.
        /// </summary>
        public const string DTREM1 = "DTREM1";

        /// <summary>
        /// DTFUTUSE2.
        /// </summary>
        public const string DTFUTUSE2 = "DTFUTUSE2";

        /// <summary>
        /// DTFUTUSE3.
        /// </summary>
        public const string DTFUTUSE3 = "DTFUTUSE3";

        /// <summary>
        /// DTFUTUSE10.
        /// </summary>
        public const string DTFUTUSE10 = "DTFUTUSE10";

        /// <summary>
        /// DTFUTUSE11.
        /// </summary>
        public const string DTFUTUSE11 = "DTFUTUSE11";

        /// <summary>
        /// DTCDFUMJ.
        /// </summary>
        public const string DTCDFUMJ = "DTCDFUMJ";

        /// <summary>
        /// DTSUFUUPMT.
        /// </summary>
        public const string DTSUFUUPMT = "DTSUFUUPMT";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTMKEY.
        /// </summary>
        public const string DTMKEY = "DTMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F96413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTUSER1", "DTUSER1", JdeDataType.String, 20, true, true),
        new JdeField("DTDATE01", "DTDATE01", JdeDataType.Numeric, null, true, true),
        new JdeField("DTTME0", "DTTME0", JdeDataType.Numeric, null, true, true),
        new JdeField("DTOMWPRJID", "DTOMWPRJID", JdeDataType.String, 60, true, true),
        new JdeField("DTPOBJNM", "DTPOBJNM", JdeDataType.String, 20, true, true),
        new JdeField("DTDOBJNM", "DTDOBJNM", JdeDataType.String, 20, true, true),
        new JdeField("DTESUP", "DTESUP", JdeDataType.String, 20),
        new JdeField("DTSUCOUNT", "DTSUCOUNT", JdeDataType.Numeric),
        new JdeField("DTDEPTYPE", "DTDEPTYPE", JdeDataType.String, 4),
        new JdeField("DTREM1", "DTREM1", JdeDataType.String, 80),
        new JdeField("DTFUTUSE2", "DTFUTUSE2", JdeDataType.String, 8),
        new JdeField("DTFUTUSE3", "DTFUTUSE3", JdeDataType.String, 8),
        new JdeField("DTFUTUSE10", "DTFUTUSE10", JdeDataType.String, 8),
        new JdeField("DTFUTUSE11", "DTFUTUSE11", JdeDataType.String, 8),
        new JdeField("DTCDFUMJ", "DTCDFUMJ", JdeDataType.Numeric),
        new JdeField("DTSUFUUPMT", "DTSUFUUPMT", JdeDataType.Numeric),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTMKEY", "DTMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F96413_0", "Primary Key on DTUSER1, DTDATE01, DTTME0, DTOMWPRJID, DTPOBJNM, DTDOBJNM", new[] { "DTUSER1", "DTDATE01", "DTTME0", "DTOMWPRJID", "DTPOBJNM", "DTDOBJNM" }, isUnique: true, isPrimaryKey: true)
    };
}
