using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0116T1 - .
/// </summary>
public class F0116T1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACAN8.
        /// </summary>
        public const string ACAN8 = "ACAN8";

        /// <summary>
        /// ACEFTB.
        /// </summary>
        public const string ACEFTB = "ACEFTB";

        /// <summary>
        /// ACADLC1.
        /// </summary>
        public const string ACADLC1 = "ACADLC1";

        /// <summary>
        /// ACADLC2.
        /// </summary>
        public const string ACADLC2 = "ACADLC2";

        /// <summary>
        /// ACADLC3.
        /// </summary>
        public const string ACADLC3 = "ACADLC3";

        /// <summary>
        /// ACADLC4.
        /// </summary>
        public const string ACADLC4 = "ACADLC4";

        /// <summary>
        /// ACADLN.
        /// </summary>
        public const string ACADLN = "ACADLN";

        /// <summary>
        /// ACPOCF.
        /// </summary>
        public const string ACPOCF = "ACPOCF";

        /// <summary>
        /// ACEFTBF.
        /// </summary>
        public const string ACEFTBF = "ACEFTBF";

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
        /// ACCTYF.
        /// </summary>
        public const string ACCTYF = "ACCTYF";

        /// <summary>
        /// ACFUCH.
        /// </summary>
        public const string ACFUCH = "ACFUCH";

        /// <summary>
        /// ACFSTRG.
        /// </summary>
        public const string ACFSTRG = "ACFSTRG";

        /// <summary>
        /// ACFUDT.
        /// </summary>
        public const string ACFUDT = "ACFUDT";

        /// <summary>
        /// ACFUNUM.
        /// </summary>
        public const string ACFUNUM = "ACFUNUM";
    }

    /// <inheritdoc />
    public override string TableName => "F0116T1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACAN8", "ACAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ACEFTB", "ACEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("ACADLC1", "ACADLC1", JdeDataType.String, 80),
        new JdeField("ACADLC2", "ACADLC2", JdeDataType.String, 80),
        new JdeField("ACADLC3", "ACADLC3", JdeDataType.String, 80),
        new JdeField("ACADLC4", "ACADLC4", JdeDataType.String, 80),
        new JdeField("ACADLN", "ACADLN", JdeDataType.String, 80),
        new JdeField("ACPOCF", "ACPOCF", JdeDataType.String, 24),
        new JdeField("ACEFTBF", "ACEFTBF", JdeDataType.String, 2),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACCTYF", "ACCTYF", JdeDataType.String, 50),
        new JdeField("ACFUCH", "ACFUCH", JdeDataType.String, 2),
        new JdeField("ACFSTRG", "ACFSTRG", JdeDataType.String, 80),
        new JdeField("ACFUDT", "ACFUDT", JdeDataType.Numeric),
        new JdeField("ACFUNUM", "ACFUNUM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0116T1_0", "Primary Key on ACEFTB, ACAN8", new[] { "ACEFTB", "ACAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0116T1_2", "Index on ACPOCF, ACADLC1, ACADLN, ACEFTBF", new[] { "ACPOCF", "ACADLC1", "ACADLN", "ACEFTBF" }),
        new JdeIndex("F0116T1_3", "Index on ACADLC2, ACADLC3, ACADLC4", new[] { "ACADLC2", "ACADLC3", "ACADLC4" }),
        new JdeIndex("F0116T1_4", "Index on ACAN8", new[] { "ACAN8" })
    };
}
