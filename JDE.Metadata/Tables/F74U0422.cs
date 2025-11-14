using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0422 - .
/// </summary>
public class F74U0422 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACKCOO.
        /// </summary>
        public const string ACKCOO = "ACKCOO";

        /// <summary>
        /// ACDOCO.
        /// </summary>
        public const string ACDOCO = "ACDOCO";

        /// <summary>
        /// ACDCTO.
        /// </summary>
        public const string ACDCTO = "ACDCTO";

        /// <summary>
        /// ACSFXO.
        /// </summary>
        public const string ACSFXO = "ACSFXO";

        /// <summary>
        /// ACUKAPNM.
        /// </summary>
        public const string ACUKAPNM = "ACUKAPNM";

        /// <summary>
        /// ACUKAPDT.
        /// </summary>
        public const string ACUKAPDT = "ACUKAPDT";

        /// <summary>
        /// ACUKCENM.
        /// </summary>
        public const string ACUKCENM = "ACUKCENM";

        /// <summary>
        /// ACUKCEDT.
        /// </summary>
        public const string ACUKCEDT = "ACUKCEDT";

        /// <summary>
        /// ACMATC.
        /// </summary>
        public const string ACMATC = "ACMATC";

        /// <summary>
        /// ACURAB.
        /// </summary>
        public const string ACURAB = "ACURAB";

        /// <summary>
        /// ACURAT.
        /// </summary>
        public const string ACURAT = "ACURAT";

        /// <summary>
        /// ACURCD.
        /// </summary>
        public const string ACURCD = "ACURCD";

        /// <summary>
        /// ACURRF.
        /// </summary>
        public const string ACURRF = "ACURRF";

        /// <summary>
        /// ACURDT.
        /// </summary>
        public const string ACURDT = "ACURDT";

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
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACKCOO", "ACKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ACDOCO", "ACDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ACDCTO", "ACDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ACSFXO", "ACSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ACUKAPNM", "ACUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("ACUKAPDT", "ACUKAPDT", JdeDataType.Numeric),
        new JdeField("ACUKCENM", "ACUKCENM", JdeDataType.Numeric, null, true, true),
        new JdeField("ACUKCEDT", "ACUKCEDT", JdeDataType.Numeric),
        new JdeField("ACMATC", "ACMATC", JdeDataType.String, 2),
        new JdeField("ACURAB", "ACURAB", JdeDataType.Numeric),
        new JdeField("ACURAT", "ACURAT", JdeDataType.Numeric),
        new JdeField("ACURCD", "ACURCD", JdeDataType.String, 4),
        new JdeField("ACURRF", "ACURRF", JdeDataType.String, 30),
        new JdeField("ACURDT", "ACURDT", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0422_0", "Primary Key on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACUKAPNM, ACUKCENM", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACUKAPNM", "ACUKCENM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0422_2", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO" }),
        new JdeIndex("F74U0422_3", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACUKAPNM", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACUKAPNM" }),
        new JdeIndex("F74U0422_4", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACUKCENM, ACMATC", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACUKCENM", "ACMATC" })
    };
}
