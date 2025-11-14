using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08122 - .
/// </summary>
public class F08122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AKRPYR.
        /// </summary>
        public const string AKRPYR = "AKRPYR";

        /// <summary>
        /// AKAIRI.
        /// </summary>
        public const string AKAIRI = "AKAIRI";

        /// <summary>
        /// AKTAXX.
        /// </summary>
        public const string AKTAXX = "AKTAXX";

        /// <summary>
        /// AKRCK5.
        /// </summary>
        public const string AKRCK5 = "AKRCK5";

        /// <summary>
        /// AKMOLN.
        /// </summary>
        public const string AKMOLN = "AKMOLN";

        /// <summary>
        /// AKMECI.
        /// </summary>
        public const string AKMECI = "AKMECI";

        /// <summary>
        /// AKFTEC.
        /// </summary>
        public const string AKFTEC = "AKFTEC";

        /// <summary>
        /// AKATEC.
        /// </summary>
        public const string AKATEC = "AKATEC";

        /// <summary>
        /// AKAGGI.
        /// </summary>
        public const string AKAGGI = "AKAGGI";

        /// <summary>
        /// AKTRIN.
        /// </summary>
        public const string AKTRIN = "AKTRIN";

        /// <summary>
        /// AKUSER.
        /// </summary>
        public const string AKUSER = "AKUSER";

        /// <summary>
        /// AKPID.
        /// </summary>
        public const string AKPID = "AKPID";

        /// <summary>
        /// AKJOBN.
        /// </summary>
        public const string AKJOBN = "AKJOBN";

        /// <summary>
        /// AKUPMJ.
        /// </summary>
        public const string AKUPMJ = "AKUPMJ";

        /// <summary>
        /// AKUPMT.
        /// </summary>
        public const string AKUPMT = "AKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AKRPYR", "AKRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AKAIRI", "AKAIRI", JdeDataType.String, 20, true, true),
        new JdeField("AKTAXX", "AKTAXX", JdeDataType.String, 40, true, true),
        new JdeField("AKRCK5", "AKRCK5", JdeDataType.Numeric, null, true, true),
        new JdeField("AKMOLN", "AKMOLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AKMECI", "AKMECI", JdeDataType.String, 2),
        new JdeField("AKFTEC", "AKFTEC", JdeDataType.Numeric),
        new JdeField("AKATEC", "AKATEC", JdeDataType.Numeric),
        new JdeField("AKAGGI", "AKAGGI", JdeDataType.String, 2),
        new JdeField("AKTRIN", "AKTRIN", JdeDataType.String, 2),
        new JdeField("AKUSER", "AKUSER", JdeDataType.String, 20),
        new JdeField("AKPID", "AKPID", JdeDataType.String, 20),
        new JdeField("AKJOBN", "AKJOBN", JdeDataType.String, 20),
        new JdeField("AKUPMJ", "AKUPMJ", JdeDataType.Numeric),
        new JdeField("AKUPMT", "AKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08122_0", "Primary Key on AKRPYR, AKAIRI, AKTAXX, AKRCK5, AKMOLN", new[] { "AKRPYR", "AKAIRI", "AKTAXX", "AKRCK5", "AKMOLN" }, isUnique: true, isPrimaryKey: true)
    };
}
