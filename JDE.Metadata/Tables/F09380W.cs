using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09380W - .
/// </summary>
public class F09380W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBRUNID.
        /// </summary>
        public const string CBRUNID = "CBRUNID";

        /// <summary>
        /// CBLINN.
        /// </summary>
        public const string CBLINN = "CBLINN";

        /// <summary>
        /// CBCOLNBR.
        /// </summary>
        public const string CBCOLNBR = "CBCOLNBR";

        /// <summary>
        /// CBGRPV1.
        /// </summary>
        public const string CBGRPV1 = "CBGRPV1";

        /// <summary>
        /// CBGRPV2.
        /// </summary>
        public const string CBGRPV2 = "CBGRPV2";

        /// <summary>
        /// CBGRPV3.
        /// </summary>
        public const string CBGRPV3 = "CBGRPV3";

        /// <summary>
        /// CBGRPV4.
        /// </summary>
        public const string CBGRPV4 = "CBGRPV4";

        /// <summary>
        /// CBGRPV5.
        /// </summary>
        public const string CBGRPV5 = "CBGRPV5";

        /// <summary>
        /// CBGRPV6.
        /// </summary>
        public const string CBGRPV6 = "CBGRPV6";

        /// <summary>
        /// CBGRPV7.
        /// </summary>
        public const string CBGRPV7 = "CBGRPV7";

        /// <summary>
        /// CBGRPV8.
        /// </summary>
        public const string CBGRPV8 = "CBGRPV8";

        /// <summary>
        /// CBGRPV9.
        /// </summary>
        public const string CBGRPV9 = "CBGRPV9";

        /// <summary>
        /// CBGRPV10.
        /// </summary>
        public const string CBGRPV10 = "CBGRPV10";

        /// <summary>
        /// CBCOLAMT.
        /// </summary>
        public const string CBCOLAMT = "CBCOLAMT";

        /// <summary>
        /// CBCRCX.
        /// </summary>
        public const string CBCRCX = "CBCRCX";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBRPSTN.
        /// </summary>
        public const string CBRPSTN = "CBRPSTN";

        /// <summary>
        /// CBVERN.
        /// </summary>
        public const string CBVERN = "CBVERN";
    }

    /// <inheritdoc />
    public override string TableName => "F09380W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBRUNID", "CBRUNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CBLINN", "CBLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("CBCOLNBR", "CBCOLNBR", JdeDataType.Numeric, null, true, true),
        new JdeField("CBGRPV1", "CBGRPV1", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV2", "CBGRPV2", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV3", "CBGRPV3", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV4", "CBGRPV4", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV5", "CBGRPV5", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV6", "CBGRPV6", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV7", "CBGRPV7", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV8", "CBGRPV8", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV9", "CBGRPV9", JdeDataType.String, 60, true, true),
        new JdeField("CBGRPV10", "CBGRPV10", JdeDataType.String, 60, true, true),
        new JdeField("CBCOLAMT", "CBCOLAMT", JdeDataType.Numeric),
        new JdeField("CBCRCX", "CBCRCX", JdeDataType.String, 6, true, true),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBRPSTN", "CBRPSTN", JdeDataType.String, 40),
        new JdeField("CBVERN", "CBVERN", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09380W_0", "Primary Key on CBRUNID, CBLINN, CBCOLNBR, CBGRPV1, CBGRPV2, CBGRPV3, CBGRPV4, CBGRPV5, CBGRPV6, CBGRPV7, CBGRPV8, CBGRPV9, CBGRPV10, CBCRCX", new[] { "CBRUNID", "CBLINN", "CBCOLNBR", "CBGRPV1", "CBGRPV2", "CBGRPV3", "CBGRPV4", "CBGRPV5", "CBGRPV6", "CBGRPV7", "CBGRPV8", "CBGRPV9", "CBGRPV10", "CBCRCX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09380W_2", "Index on CBUSER, CBRPSTN, CBVERN", new[] { "CBUSER", "CBRPSTN", "CBVERN" }),
        new JdeIndex("F09380W_3", "Index on CBRUNID, CBLINN, CBGRPV1, CBGRPV2, CBGRPV3, CBGRPV4, CBGRPV5, CBGRPV6, CBGRPV7, CBGRPV8, CBGRPV9, CBGRPV10, CBCOLNBR, CBCRCX", new[] { "CBRUNID", "CBLINN", "CBGRPV1", "CBGRPV2", "CBGRPV3", "CBGRPV4", "CBGRPV5", "CBGRPV6", "CBGRPV7", "CBGRPV8", "CBGRPV9", "CBGRPV10", "CBCOLNBR", "CBCRCX" })
    };
}
