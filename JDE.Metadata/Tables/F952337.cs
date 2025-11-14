using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952337 - .
/// </summary>
public class F952337 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDPUBLISTID.
        /// </summary>
        public const string PDPUBLISTID = "PDPUBLISTID";

        /// <summary>
        /// PDPUBTARGT.
        /// </summary>
        public const string PDPUBTARGT = "PDPUBTARGT";

        /// <summary>
        /// PDPUBFU1.
        /// </summary>
        public const string PDPUBFU1 = "PDPUBFU1";

        /// <summary>
        /// PDPUBFU2.
        /// </summary>
        public const string PDPUBFU2 = "PDPUBFU2";

        /// <summary>
        /// PDPUBFU3.
        /// </summary>
        public const string PDPUBFU3 = "PDPUBFU3";

        /// <summary>
        /// PDPUBFU4.
        /// </summary>
        public const string PDPUBFU4 = "PDPUBFU4";

        /// <summary>
        /// PDPUBFU5.
        /// </summary>
        public const string PDPUBFU5 = "PDPUBFU5";

        /// <summary>
        /// PDPUBFU6.
        /// </summary>
        public const string PDPUBFU6 = "PDPUBFU6";

        /// <summary>
        /// PDPUBFU7.
        /// </summary>
        public const string PDPUBFU7 = "PDPUBFU7";

        /// <summary>
        /// PDPUBFU8.
        /// </summary>
        public const string PDPUBFU8 = "PDPUBFU8";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDMKEY.
        /// </summary>
        public const string PDMKEY = "PDMKEY";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F952337";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDPUBLISTID", "PDPUBLISTID", JdeDataType.String, 20, true, true),
        new JdeField("PDPUBTARGT", "PDPUBTARGT", JdeDataType.String, 20, true, true),
        new JdeField("PDPUBFU1", "PDPUBFU1", JdeDataType.String, 2),
        new JdeField("PDPUBFU2", "PDPUBFU2", JdeDataType.String, 2),
        new JdeField("PDPUBFU3", "PDPUBFU3", JdeDataType.String, 60),
        new JdeField("PDPUBFU4", "PDPUBFU4", JdeDataType.String, 60),
        new JdeField("PDPUBFU5", "PDPUBFU5", JdeDataType.Numeric),
        new JdeField("PDPUBFU6", "PDPUBFU6", JdeDataType.Numeric),
        new JdeField("PDPUBFU7", "PDPUBFU7", JdeDataType.String, 500),
        new JdeField("PDPUBFU8", "PDPUBFU8", JdeDataType.String, 500),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDMKEY", "PDMKEY", JdeDataType.String, 30),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952337_0", "Primary Key on PDPUBLISTID, PDPUBTARGT", new[] { "PDPUBLISTID", "PDPUBTARGT" }, isUnique: true, isPrimaryKey: true)
    };
}
