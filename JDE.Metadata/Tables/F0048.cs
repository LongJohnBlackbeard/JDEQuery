using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0048 - .
/// </summary>
public class F0048 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMSY.
        /// </summary>
        public const string CMSY = "CMSY";

        /// <summary>
        /// CMRT.
        /// </summary>
        public const string CMRT = "CMRT";

        /// <summary>
        /// CMDTAI.
        /// </summary>
        public const string CMDTAI = "CMDTAI";

        /// <summary>
        /// CMVNDN.
        /// </summary>
        public const string CMVNDN = "CMVNDN";

        /// <summary>
        /// CMDRIN.
        /// </summary>
        public const string CMDRIN = "CMDRIN";

        /// <summary>
        /// CMKY.
        /// </summary>
        public const string CMKY = "CMKY";

        /// <summary>
        /// CMKYX.
        /// </summary>
        public const string CMKYX = "CMKYX";

        /// <summary>
        /// CMDEL.
        /// </summary>
        public const string CMDEL = "CMDEL";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0048";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMSY", "CMSY", JdeDataType.String, 8, true, true),
        new JdeField("CMRT", "CMRT", JdeDataType.String, 4, true, true),
        new JdeField("CMDTAI", "CMDTAI", JdeDataType.String, 20, true, true),
        new JdeField("CMVNDN", "CMVNDN", JdeDataType.String, 20, true, true),
        new JdeField("CMDRIN", "CMDRIN", JdeDataType.String, 2, true, true),
        new JdeField("CMKY", "CMKY", JdeDataType.String, 20, true, true),
        new JdeField("CMKYX", "CMKYX", JdeDataType.String, 60, true, true),
        new JdeField("CMDEL", "CMDEL", JdeDataType.String, 2),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0048_0", "Primary Key on CMSY, CMRT, CMDTAI, CMVNDN, CMDRIN, CMKY, CMKYX", new[] { "CMSY", "CMRT", "CMDTAI", "CMVNDN", "CMDRIN", "CMKY", "CMKYX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0048_2", "Index on CMSY, CMRT, CMVNDN, CMDRIN, CMKY, CMKYX", new[] { "CMSY", "CMRT", "CMVNDN", "CMDRIN", "CMKY", "CMKYX" }),
        new JdeIndex("F0048_3", "Index on CMSY, CMRT, CMVNDN, CMDRIN, CMKYX, CMKY", new[] { "CMSY", "CMRT", "CMVNDN", "CMDRIN", "CMKYX", "CMKY" }),
        new JdeIndex("F0048_4", "Index on CMDTAI, CMVNDN, CMDRIN, CMKY, CMKYX", new[] { "CMDTAI", "CMVNDN", "CMDRIN", "CMKY", "CMKYX" }),
        new JdeIndex("F0048_5", "Index on CMDTAI, CMVNDN, CMDRIN, CMKYX, CMKY", new[] { "CMDTAI", "CMVNDN", "CMDRIN", "CMKYX", "CMKY" })
    };
}
