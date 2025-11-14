using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30008 - .
/// </summary>
public class F30008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWMCU.
        /// </summary>
        public const string IWMCU = "IWMCU";

        /// <summary>
        /// IWLEDG.
        /// </summary>
        public const string IWLEDG = "IWLEDG";

        /// <summary>
        /// IWSTLF.
        /// </summary>
        public const string IWSTLF = "IWSTLF";

        /// <summary>
        /// IWXSDL.
        /// </summary>
        public const string IWXSDL = "IWXSDL";

        /// <summary>
        /// IWSTFF.
        /// </summary>
        public const string IWSTFF = "IWSTFF";

        /// <summary>
        /// IWXSSL.
        /// </summary>
        public const string IWXSSL = "IWXSSL";

        /// <summary>
        /// IWSIDL.
        /// </summary>
        public const string IWSIDL = "IWSIDL";

        /// <summary>
        /// IWXSIL.
        /// </summary>
        public const string IWXSIL = "IWXSIL";

        /// <summary>
        /// IWSTRF.
        /// </summary>
        public const string IWSTRF = "IWSTRF";

        /// <summary>
        /// IWXSVO.
        /// </summary>
        public const string IWXSVO = "IWXSVO";

        /// <summary>
        /// IWSTRZ.
        /// </summary>
        public const string IWSTRZ = "IWSTRZ";

        /// <summary>
        /// IWXSFO.
        /// </summary>
        public const string IWXSFO = "IWXSFO";

        /// <summary>
        /// IWMSFR.
        /// </summary>
        public const string IWMSFR = "IWMSFR";

        /// <summary>
        /// IWXSMR.
        /// </summary>
        public const string IWXSMR = "IWXSMR";

        /// <summary>
        /// IWMSTF.
        /// </summary>
        public const string IWMSTF = "IWMSTF";

        /// <summary>
        /// IWXSMV.
        /// </summary>
        public const string IWXSMV = "IWXSMV";

        /// <summary>
        /// IWMSSF.
        /// </summary>
        public const string IWMSSF = "IWMSSF";

        /// <summary>
        /// IWXSMF.
        /// </summary>
        public const string IWXSMF = "IWXSMF";

        /// <summary>
        /// IWSTAF.
        /// </summary>
        public const string IWSTAF = "IWSTAF";

        /// <summary>
        /// IWUSER.
        /// </summary>
        public const string IWUSER = "IWUSER";

        /// <summary>
        /// IWPID.
        /// </summary>
        public const string IWPID = "IWPID";

        /// <summary>
        /// IWUPMJ.
        /// </summary>
        public const string IWUPMJ = "IWUPMJ";

        /// <summary>
        /// IWTDAY.
        /// </summary>
        public const string IWTDAY = "IWTDAY";

        /// <summary>
        /// IWJOBN.
        /// </summary>
        public const string IWJOBN = "IWJOBN";

        /// <summary>
        /// IWMMCU.
        /// </summary>
        public const string IWMMCU = "IWMMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F30008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWMCU", "IWMCU", JdeDataType.String, 24, true, true),
        new JdeField("IWLEDG", "IWLEDG", JdeDataType.String, 4, true, true),
        new JdeField("IWSTLF", "IWSTLF", JdeDataType.Numeric),
        new JdeField("IWXSDL", "IWXSDL", JdeDataType.Numeric),
        new JdeField("IWSTFF", "IWSTFF", JdeDataType.Numeric),
        new JdeField("IWXSSL", "IWXSSL", JdeDataType.Numeric),
        new JdeField("IWSIDL", "IWSIDL", JdeDataType.Numeric),
        new JdeField("IWXSIL", "IWXSIL", JdeDataType.Numeric),
        new JdeField("IWSTRF", "IWSTRF", JdeDataType.Numeric),
        new JdeField("IWXSVO", "IWXSVO", JdeDataType.Numeric),
        new JdeField("IWSTRZ", "IWSTRZ", JdeDataType.Numeric),
        new JdeField("IWXSFO", "IWXSFO", JdeDataType.Numeric),
        new JdeField("IWMSFR", "IWMSFR", JdeDataType.Numeric),
        new JdeField("IWXSMR", "IWXSMR", JdeDataType.Numeric),
        new JdeField("IWMSTF", "IWMSTF", JdeDataType.Numeric),
        new JdeField("IWXSMV", "IWXSMV", JdeDataType.Numeric),
        new JdeField("IWMSSF", "IWMSSF", JdeDataType.Numeric),
        new JdeField("IWXSMF", "IWXSMF", JdeDataType.Numeric),
        new JdeField("IWSTAF", "IWSTAF", JdeDataType.Numeric),
        new JdeField("IWUSER", "IWUSER", JdeDataType.String, 20),
        new JdeField("IWPID", "IWPID", JdeDataType.String, 20),
        new JdeField("IWUPMJ", "IWUPMJ", JdeDataType.Numeric),
        new JdeField("IWTDAY", "IWTDAY", JdeDataType.Numeric),
        new JdeField("IWJOBN", "IWJOBN", JdeDataType.String, 20),
        new JdeField("IWMMCU", "IWMMCU", JdeDataType.String, 24, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30008_0", "Primary Key on IWMMCU, IWMCU, IWLEDG", new[] { "IWMMCU", "IWMCU", "IWLEDG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30008_2", "Index on IWLEDG, IWMMCU, IWMCU", new[] { "IWLEDG", "IWMMCU", "IWMCU" })
    };
}
