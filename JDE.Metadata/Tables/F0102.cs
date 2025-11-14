using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0102 - .
/// </summary>
public class F0102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACAT1.
        /// </summary>
        public const string ACAT1 = "ACAT1";

        /// <summary>
        /// ACRAL.
        /// </summary>
        public const string ACRAL = "ACRAL";

        /// <summary>
        /// ACRTD.
        /// </summary>
        public const string ACRTD = "ACRTD";

        /// <summary>
        /// ACRCNTRY.
        /// </summary>
        public const string ACRCNTRY = "ACRCNTRY";

        /// <summary>
        /// ACRSTAT.
        /// </summary>
        public const string ACRSTAT = "ACRSTAT";

        /// <summary>
        /// ACRCY.
        /// </summary>
        public const string ACRCY = "ACRCY";

        /// <summary>
        /// ACRCNTY.
        /// </summary>
        public const string ACRCNTY = "ACRCNTY";

        /// <summary>
        /// ACRPOC.
        /// </summary>
        public const string ACRPOC = "ACRPOC";

        /// <summary>
        /// ACEW.
        /// </summary>
        public const string ACEW = "ACEW";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACFCH.
        /// </summary>
        public const string ACFCH = "ACFCH";

        /// <summary>
        /// ACFUSTR.
        /// </summary>
        public const string ACFUSTR = "ACFUSTR";

        /// <summary>
        /// ACFDTE.
        /// </summary>
        public const string ACFDTE = "ACFDTE";

        /// <summary>
        /// ACFNMR.
        /// </summary>
        public const string ACFNMR = "ACFNMR";

        /// <summary>
        /// ACFUCH1.
        /// </summary>
        public const string ACFUCH1 = "ACFUCH1";

        /// <summary>
        /// ACFUCH2.
        /// </summary>
        public const string ACFUCH2 = "ACFUCH2";

        /// <summary>
        /// ACFUCH3.
        /// </summary>
        public const string ACFUCH3 = "ACFUCH3";
    }

    /// <inheritdoc />
    public override string TableName => "F0102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACAT1", "ACAT1", JdeDataType.String, 6, true, true),
        new JdeField("ACRAL", "ACRAL", JdeDataType.String, 2),
        new JdeField("ACRTD", "ACRTD", JdeDataType.String, 2),
        new JdeField("ACRCNTRY", "ACRCNTRY", JdeDataType.String, 2),
        new JdeField("ACRSTAT", "ACRSTAT", JdeDataType.String, 2),
        new JdeField("ACRCY", "ACRCY", JdeDataType.String, 2),
        new JdeField("ACRCNTY", "ACRCNTY", JdeDataType.String, 2),
        new JdeField("ACRPOC", "ACRPOC", JdeDataType.String, 2),
        new JdeField("ACEW", "ACEW", JdeDataType.String, 2),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACFCH", "ACFCH", JdeDataType.String, 2),
        new JdeField("ACFUSTR", "ACFUSTR", JdeDataType.String, 80),
        new JdeField("ACFDTE", "ACFDTE", JdeDataType.Numeric),
        new JdeField("ACFNMR", "ACFNMR", JdeDataType.Numeric),
        new JdeField("ACFUCH1", "ACFUCH1", JdeDataType.String, 2),
        new JdeField("ACFUCH2", "ACFUCH2", JdeDataType.String, 2),
        new JdeField("ACFUCH3", "ACFUCH3", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0102_0", "Primary Key on ACAT1", new[] { "ACAT1" }, isUnique: true, isPrimaryKey: true)
    };
}
