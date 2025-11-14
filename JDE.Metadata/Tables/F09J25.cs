using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J25 - .
/// </summary>
public class F09J25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CLJVSLT.
        /// </summary>
        public const string CLJVSLT = "CLJVSLT";

        /// <summary>
        /// CLJVOCLT.
        /// </summary>
        public const string CLJVOCLT = "CLJVOCLT";

        /// <summary>
        /// CLJVICLT.
        /// </summary>
        public const string CLJVICLT = "CLJVICLT";

        /// <summary>
        /// CLJVORSF.
        /// </summary>
        public const string CLJVORSF = "CLJVORSF";

        /// <summary>
        /// CLJVIRSF.
        /// </summary>
        public const string CLJVIRSF = "CLJVIRSF";

        /// <summary>
        /// CLTORG.
        /// </summary>
        public const string CLTORG = "CLTORG";

        /// <summary>
        /// CLENTJ.
        /// </summary>
        public const string CLENTJ = "CLENTJ";

        /// <summary>
        /// CLUSER.
        /// </summary>
        public const string CLUSER = "CLUSER";

        /// <summary>
        /// CLUPMJ.
        /// </summary>
        public const string CLUPMJ = "CLUPMJ";

        /// <summary>
        /// CLUPMT.
        /// </summary>
        public const string CLUPMT = "CLUPMT";

        /// <summary>
        /// CLPID.
        /// </summary>
        public const string CLPID = "CLPID";

        /// <summary>
        /// CLMKEY.
        /// </summary>
        public const string CLMKEY = "CLMKEY";

        /// <summary>
        /// CLURAB.
        /// </summary>
        public const string CLURAB = "CLURAB";

        /// <summary>
        /// CLURCD.
        /// </summary>
        public const string CLURCD = "CLURCD";

        /// <summary>
        /// CLURAT.
        /// </summary>
        public const string CLURAT = "CLURAT";

        /// <summary>
        /// CLURDT.
        /// </summary>
        public const string CLURDT = "CLURDT";

        /// <summary>
        /// CLURRF.
        /// </summary>
        public const string CLURRF = "CLURRF";

        /// <summary>
        /// CLJVCBNU1.
        /// </summary>
        public const string CLJVCBNU1 = "CLJVCBNU1";

        /// <summary>
        /// CLJVCBNU2.
        /// </summary>
        public const string CLJVCBNU2 = "CLJVCBNU2";

        /// <summary>
        /// CLJVCBNU3.
        /// </summary>
        public const string CLJVCBNU3 = "CLJVCBNU3";

        /// <summary>
        /// CLJVCBST1.
        /// </summary>
        public const string CLJVCBST1 = "CLJVCBST1";

        /// <summary>
        /// CLJVCBST2.
        /// </summary>
        public const string CLJVCBST2 = "CLJVCBST2";

        /// <summary>
        /// CLJVCBST3.
        /// </summary>
        public const string CLJVCBST3 = "CLJVCBST3";

        /// <summary>
        /// CLJVCBCH1.
        /// </summary>
        public const string CLJVCBCH1 = "CLJVCBCH1";

        /// <summary>
        /// CLJVCBCH2.
        /// </summary>
        public const string CLJVCBCH2 = "CLJVCBCH2";

        /// <summary>
        /// CLJVCBCH3.
        /// </summary>
        public const string CLJVCBCH3 = "CLJVCBCH3";

        /// <summary>
        /// CLJVCBDT1.
        /// </summary>
        public const string CLJVCBDT1 = "CLJVCBDT1";

        /// <summary>
        /// CLJVCBDT2.
        /// </summary>
        public const string CLJVCBDT2 = "CLJVCBDT2";

        /// <summary>
        /// CLJVCBDT3.
        /// </summary>
        public const string CLJVCBDT3 = "CLJVCBDT3";
    }

    /// <inheritdoc />
    public override string TableName => "F09J25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CLJVSLT", "CLJVSLT", JdeDataType.String, 4, true, true),
        new JdeField("CLJVOCLT", "CLJVOCLT", JdeDataType.String, 4),
        new JdeField("CLJVICLT", "CLJVICLT", JdeDataType.String, 4),
        new JdeField("CLJVORSF", "CLJVORSF", JdeDataType.String, 2),
        new JdeField("CLJVIRSF", "CLJVIRSF", JdeDataType.String, 2),
        new JdeField("CLTORG", "CLTORG", JdeDataType.String, 20),
        new JdeField("CLENTJ", "CLENTJ", JdeDataType.Numeric),
        new JdeField("CLUSER", "CLUSER", JdeDataType.String, 20),
        new JdeField("CLUPMJ", "CLUPMJ", JdeDataType.Numeric),
        new JdeField("CLUPMT", "CLUPMT", JdeDataType.Numeric),
        new JdeField("CLPID", "CLPID", JdeDataType.String, 20),
        new JdeField("CLMKEY", "CLMKEY", JdeDataType.String, 30),
        new JdeField("CLURAB", "CLURAB", JdeDataType.Numeric),
        new JdeField("CLURCD", "CLURCD", JdeDataType.String, 4),
        new JdeField("CLURAT", "CLURAT", JdeDataType.Numeric),
        new JdeField("CLURDT", "CLURDT", JdeDataType.Numeric),
        new JdeField("CLURRF", "CLURRF", JdeDataType.String, 30),
        new JdeField("CLJVCBNU1", "CLJVCBNU1", JdeDataType.Numeric),
        new JdeField("CLJVCBNU2", "CLJVCBNU2", JdeDataType.Numeric),
        new JdeField("CLJVCBNU3", "CLJVCBNU3", JdeDataType.Numeric),
        new JdeField("CLJVCBST1", "CLJVCBST1", JdeDataType.String, 160),
        new JdeField("CLJVCBST2", "CLJVCBST2", JdeDataType.String, 160),
        new JdeField("CLJVCBST3", "CLJVCBST3", JdeDataType.String, 160),
        new JdeField("CLJVCBCH1", "CLJVCBCH1", JdeDataType.String, 2),
        new JdeField("CLJVCBCH2", "CLJVCBCH2", JdeDataType.String, 2),
        new JdeField("CLJVCBCH3", "CLJVCBCH3", JdeDataType.String, 2),
        new JdeField("CLJVCBDT1", "CLJVCBDT1", JdeDataType.Numeric),
        new JdeField("CLJVCBDT2", "CLJVCBDT2", JdeDataType.Numeric),
        new JdeField("CLJVCBDT3", "CLJVCBDT3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J25_0", "Primary Key on CLJVSLT", new[] { "CLJVSLT" }, isUnique: true, isPrimaryKey: true)
    };
}
