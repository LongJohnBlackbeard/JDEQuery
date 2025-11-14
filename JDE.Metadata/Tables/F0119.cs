using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0119 - .
/// </summary>
public class F0119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PXAN8.
        /// </summary>
        public const string PXAN8 = "PXAN8";

        /// <summary>
        /// PXALPH.
        /// </summary>
        public const string PXALPH = "PXALPH";

        /// <summary>
        /// PXADD1.
        /// </summary>
        public const string PXADD1 = "PXADD1";

        /// <summary>
        /// PXADD2.
        /// </summary>
        public const string PXADD2 = "PXADD2";

        /// <summary>
        /// PXADD4.
        /// </summary>
        public const string PXADD4 = "PXADD4";

        /// <summary>
        /// PXADD3.
        /// </summary>
        public const string PXADD3 = "PXADD3";

        /// <summary>
        /// PXCOUN.
        /// </summary>
        public const string PXCOUN = "PXCOUN";

        /// <summary>
        /// PXADDZ.
        /// </summary>
        public const string PXADDZ = "PXADDZ";

        /// <summary>
        /// PXCTY1.
        /// </summary>
        public const string PXCTY1 = "PXCTY1";

        /// <summary>
        /// PXADDS.
        /// </summary>
        public const string PXADDS = "PXADDS";

        /// <summary>
        /// PXCTR.
        /// </summary>
        public const string PXCTR = "PXCTR";

        /// <summary>
        /// PXNLATT.
        /// </summary>
        public const string PXNLATT = "PXNLATT";

        /// <summary>
        /// PXNLONG.
        /// </summary>
        public const string PXNLONG = "PXNLONG";

        /// <summary>
        /// PXEV01.
        /// </summary>
        public const string PXEV01 = "PXEV01";

        /// <summary>
        /// PXUSER.
        /// </summary>
        public const string PXUSER = "PXUSER";

        /// <summary>
        /// PXPID.
        /// </summary>
        public const string PXPID = "PXPID";

        /// <summary>
        /// PXUPMJ.
        /// </summary>
        public const string PXUPMJ = "PXUPMJ";

        /// <summary>
        /// PXJOBN.
        /// </summary>
        public const string PXJOBN = "PXJOBN";

        /// <summary>
        /// PXUPMT.
        /// </summary>
        public const string PXUPMT = "PXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PXAN8", "PXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PXALPH", "PXALPH", JdeDataType.String, 80),
        new JdeField("PXADD1", "PXADD1", JdeDataType.String, 80),
        new JdeField("PXADD2", "PXADD2", JdeDataType.String, 80),
        new JdeField("PXADD4", "PXADD4", JdeDataType.String, 80),
        new JdeField("PXADD3", "PXADD3", JdeDataType.String, 80),
        new JdeField("PXCOUN", "PXCOUN", JdeDataType.String, 50),
        new JdeField("PXADDZ", "PXADDZ", JdeDataType.String, 24),
        new JdeField("PXCTY1", "PXCTY1", JdeDataType.String, 50),
        new JdeField("PXADDS", "PXADDS", JdeDataType.String, 6),
        new JdeField("PXCTR", "PXCTR", JdeDataType.String, 6),
        new JdeField("PXNLATT", "PXNLATT", JdeDataType.Numeric),
        new JdeField("PXNLONG", "PXNLONG", JdeDataType.Numeric),
        new JdeField("PXEV01", "PXEV01", JdeDataType.String, 2),
        new JdeField("PXUSER", "PXUSER", JdeDataType.String, 20),
        new JdeField("PXPID", "PXPID", JdeDataType.String, 20),
        new JdeField("PXUPMJ", "PXUPMJ", JdeDataType.Numeric),
        new JdeField("PXJOBN", "PXJOBN", JdeDataType.String, 20),
        new JdeField("PXUPMT", "PXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0119_0", "Primary Key on PXAN8", new[] { "PXAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
