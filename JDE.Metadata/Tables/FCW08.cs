using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW08 - .
/// </summary>
public class FCW08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WKC9ITM.
        /// </summary>
        public const string WKC9ITM = "WKC9ITM";

        /// <summary>
        /// WKEV01.
        /// </summary>
        public const string WKEV01 = "WKEV01";

        /// <summary>
        /// WKSRP1.
        /// </summary>
        public const string WKSRP1 = "WKSRP1";

        /// <summary>
        /// WKSRP2.
        /// </summary>
        public const string WKSRP2 = "WKSRP2";

        /// <summary>
        /// WKSRP3.
        /// </summary>
        public const string WKSRP3 = "WKSRP3";

        /// <summary>
        /// WKSRP4.
        /// </summary>
        public const string WKSRP4 = "WKSRP4";

        /// <summary>
        /// WKSRP5.
        /// </summary>
        public const string WKSRP5 = "WKSRP5";

        /// <summary>
        /// WKSRP6.
        /// </summary>
        public const string WKSRP6 = "WKSRP6";

        /// <summary>
        /// WKSRP7.
        /// </summary>
        public const string WKSRP7 = "WKSRP7";

        /// <summary>
        /// WKSRP8.
        /// </summary>
        public const string WKSRP8 = "WKSRP8";

        /// <summary>
        /// WKSRP9.
        /// </summary>
        public const string WKSRP9 = "WKSRP9";

        /// <summary>
        /// WKSRP0.
        /// </summary>
        public const string WKSRP0 = "WKSRP0";

        /// <summary>
        /// WKCARS.
        /// </summary>
        public const string WKCARS = "WKCARS";

        /// <summary>
        /// WKCARP.
        /// </summary>
        public const string WKCARP = "WKCARP";

        /// <summary>
        /// WKSHCN.
        /// </summary>
        public const string WKSHCN = "WKSHCN";

        /// <summary>
        /// WKSHCM.
        /// </summary>
        public const string WKSHCM = "WKSHCM";

        /// <summary>
        /// WKCYCL.
        /// </summary>
        public const string WKCYCL = "WKCYCL";

        /// <summary>
        /// WKPRP1.
        /// </summary>
        public const string WKPRP1 = "WKPRP1";

        /// <summary>
        /// WKPRP2.
        /// </summary>
        public const string WKPRP2 = "WKPRP2";

        /// <summary>
        /// WKPRP3.
        /// </summary>
        public const string WKPRP3 = "WKPRP3";

        /// <summary>
        /// WKPRP4.
        /// </summary>
        public const string WKPRP4 = "WKPRP4";

        /// <summary>
        /// WKPRP5.
        /// </summary>
        public const string WKPRP5 = "WKPRP5";

        /// <summary>
        /// WKPRP6.
        /// </summary>
        public const string WKPRP6 = "WKPRP6";

        /// <summary>
        /// WKPRP7.
        /// </summary>
        public const string WKPRP7 = "WKPRP7";

        /// <summary>
        /// WKPRP8.
        /// </summary>
        public const string WKPRP8 = "WKPRP8";

        /// <summary>
        /// WKPRP9.
        /// </summary>
        public const string WKPRP9 = "WKPRP9";

        /// <summary>
        /// WKPRP0.
        /// </summary>
        public const string WKPRP0 = "WKPRP0";
    }

    /// <inheritdoc />
    public override string TableName => "FCW08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WKC9ITM", "WKC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WKEV01", "WKEV01", JdeDataType.String, 2, true, true),
        new JdeField("WKSRP1", "WKSRP1", JdeDataType.String, 6),
        new JdeField("WKSRP2", "WKSRP2", JdeDataType.String, 6),
        new JdeField("WKSRP3", "WKSRP3", JdeDataType.String, 6),
        new JdeField("WKSRP4", "WKSRP4", JdeDataType.String, 6),
        new JdeField("WKSRP5", "WKSRP5", JdeDataType.String, 6),
        new JdeField("WKSRP6", "WKSRP6", JdeDataType.String, 12),
        new JdeField("WKSRP7", "WKSRP7", JdeDataType.String, 12),
        new JdeField("WKSRP8", "WKSRP8", JdeDataType.String, 12),
        new JdeField("WKSRP9", "WKSRP9", JdeDataType.String, 12),
        new JdeField("WKSRP0", "WKSRP0", JdeDataType.String, 12),
        new JdeField("WKCARS", "WKCARS", JdeDataType.Numeric),
        new JdeField("WKCARP", "WKCARP", JdeDataType.Numeric),
        new JdeField("WKSHCN", "WKSHCN", JdeDataType.String, 6),
        new JdeField("WKSHCM", "WKSHCM", JdeDataType.String, 6),
        new JdeField("WKCYCL", "WKCYCL", JdeDataType.String, 6),
        new JdeField("WKPRP1", "WKPRP1", JdeDataType.String, 6),
        new JdeField("WKPRP2", "WKPRP2", JdeDataType.String, 6),
        new JdeField("WKPRP3", "WKPRP3", JdeDataType.String, 6),
        new JdeField("WKPRP4", "WKPRP4", JdeDataType.String, 6),
        new JdeField("WKPRP5", "WKPRP5", JdeDataType.String, 6),
        new JdeField("WKPRP6", "WKPRP6", JdeDataType.String, 12),
        new JdeField("WKPRP7", "WKPRP7", JdeDataType.String, 12),
        new JdeField("WKPRP8", "WKPRP8", JdeDataType.String, 12),
        new JdeField("WKPRP9", "WKPRP9", JdeDataType.String, 12),
        new JdeField("WKPRP0", "WKPRP0", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW08_0", "Primary Key on WKC9ITM, WKEV01", new[] { "WKC9ITM", "WKEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
