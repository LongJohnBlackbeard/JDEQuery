using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0141 - .
/// </summary>
public class F74U0141 : JdeTable
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
        /// ACLNID.
        /// </summary>
        public const string ACLNID = "ACLNID";

        /// <summary>
        /// ACUKAPNM.
        /// </summary>
        public const string ACUKAPNM = "ACUKAPNM";

        /// <summary>
        /// ACNLIN.
        /// </summary>
        public const string ACNLIN = "ACNLIN";

        /// <summary>
        /// ACMATC.
        /// </summary>
        public const string ACMATC = "ACMATC";

        /// <summary>
        /// ACUKAPRF.
        /// </summary>
        public const string ACUKAPRF = "ACUKAPRF";

        /// <summary>
        /// ACUKAPST.
        /// </summary>
        public const string ACUKAPST = "ACUKAPST";

        /// <summary>
        /// ACUKAPDT.
        /// </summary>
        public const string ACUKAPDT = "ACUKAPDT";

        /// <summary>
        /// ACUKAPQT.
        /// </summary>
        public const string ACUKAPQT = "ACUKAPQT";

        /// <summary>
        /// ACUKAPAM.
        /// </summary>
        public const string ACUKAPAM = "ACUKAPAM";

        /// <summary>
        /// ACUKAPFA.
        /// </summary>
        public const string ACUKAPFA = "ACUKAPFA";

        /// <summary>
        /// ACUKAPPE.
        /// </summary>
        public const string ACUKAPPE = "ACUKAPPE";

        /// <summary>
        /// ACUKAPCQ.
        /// </summary>
        public const string ACUKAPCQ = "ACUKAPCQ";

        /// <summary>
        /// ACUKAPCA.
        /// </summary>
        public const string ACUKAPCA = "ACUKAPCA";

        /// <summary>
        /// ACUKAPFC.
        /// </summary>
        public const string ACUKAPFC = "ACUKAPFC";

        /// <summary>
        /// ACUKAPCP.
        /// </summary>
        public const string ACUKAPCP = "ACUKAPCP";

        /// <summary>
        /// ACUKCENM.
        /// </summary>
        public const string ACUKCENM = "ACUKCENM";

        /// <summary>
        /// ACUKCERF.
        /// </summary>
        public const string ACUKCERF = "ACUKCERF";

        /// <summary>
        /// ACUKCEDT.
        /// </summary>
        public const string ACUKCEDT = "ACUKCEDT";

        /// <summary>
        /// ACCCD0.
        /// </summary>
        public const string ACCCD0 = "ACCCD0";

        /// <summary>
        /// ACUKCEQT.
        /// </summary>
        public const string ACUKCEQT = "ACUKCEQT";

        /// <summary>
        /// ACUKCEAM.
        /// </summary>
        public const string ACUKCEAM = "ACUKCEAM";

        /// <summary>
        /// ACUKCEFA.
        /// </summary>
        public const string ACUKCEFA = "ACUKCEFA";

        /// <summary>
        /// ACUKCEPE.
        /// </summary>
        public const string ACUKCEPE = "ACUKCEPE";

        /// <summary>
        /// ACUKCECQ.
        /// </summary>
        public const string ACUKCECQ = "ACUKCECQ";

        /// <summary>
        /// ACUKCECA.
        /// </summary>
        public const string ACUKCECA = "ACUKCECA";

        /// <summary>
        /// ACUKCEFC.
        /// </summary>
        public const string ACUKCEFC = "ACUKCEFC";

        /// <summary>
        /// ACUKCECP.
        /// </summary>
        public const string ACUKCECP = "ACUKCECP";

        /// <summary>
        /// ACUKCEPT.
        /// </summary>
        public const string ACUKCEPT = "ACUKCEPT";

        /// <summary>
        /// ACUKCEPD.
        /// </summary>
        public const string ACUKCEPD = "ACUKCEPD";

        /// <summary>
        /// ACICU.
        /// </summary>
        public const string ACICU = "ACICU";

        /// <summary>
        /// ACUKURRF.
        /// </summary>
        public const string ACUKURRF = "ACUKURRF";

        /// <summary>
        /// ACUKURDT.
        /// </summary>
        public const string ACUKURDT = "ACUKURDT";

        /// <summary>
        /// ACUKURC1.
        /// </summary>
        public const string ACUKURC1 = "ACUKURC1";

        /// <summary>
        /// ACUKURAT.
        /// </summary>
        public const string ACUKURAT = "ACUKURAT";

        /// <summary>
        /// ACUKURAB.
        /// </summary>
        public const string ACUKURAB = "ACUKURAB";

        /// <summary>
        /// ACUKCEST.
        /// </summary>
        public const string ACUKCEST = "ACUKCEST";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACKCOO", "ACKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ACDOCO", "ACDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ACDCTO", "ACDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ACSFXO", "ACSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ACLNID", "ACLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACUKAPNM", "ACUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("ACNLIN", "ACNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("ACMATC", "ACMATC", JdeDataType.String, 2, true, true),
        new JdeField("ACUKAPRF", "ACUKAPRF", JdeDataType.String, 60),
        new JdeField("ACUKAPST", "ACUKAPST", JdeDataType.String, 2),
        new JdeField("ACUKAPDT", "ACUKAPDT", JdeDataType.Numeric),
        new JdeField("ACUKAPQT", "ACUKAPQT", JdeDataType.Numeric),
        new JdeField("ACUKAPAM", "ACUKAPAM", JdeDataType.Numeric),
        new JdeField("ACUKAPFA", "ACUKAPFA", JdeDataType.Numeric),
        new JdeField("ACUKAPPE", "ACUKAPPE", JdeDataType.Numeric),
        new JdeField("ACUKAPCQ", "ACUKAPCQ", JdeDataType.Numeric),
        new JdeField("ACUKAPCA", "ACUKAPCA", JdeDataType.Numeric),
        new JdeField("ACUKAPFC", "ACUKAPFC", JdeDataType.Numeric),
        new JdeField("ACUKAPCP", "ACUKAPCP", JdeDataType.Numeric),
        new JdeField("ACUKCENM", "ACUKCENM", JdeDataType.Numeric),
        new JdeField("ACUKCERF", "ACUKCERF", JdeDataType.String, 60),
        new JdeField("ACUKCEDT", "ACUKCEDT", JdeDataType.Numeric),
        new JdeField("ACCCD0", "ACCCD0", JdeDataType.String, 6),
        new JdeField("ACUKCEQT", "ACUKCEQT", JdeDataType.Numeric),
        new JdeField("ACUKCEAM", "ACUKCEAM", JdeDataType.Numeric),
        new JdeField("ACUKCEFA", "ACUKCEFA", JdeDataType.Numeric),
        new JdeField("ACUKCEPE", "ACUKCEPE", JdeDataType.Numeric),
        new JdeField("ACUKCECQ", "ACUKCECQ", JdeDataType.Numeric),
        new JdeField("ACUKCECA", "ACUKCECA", JdeDataType.Numeric),
        new JdeField("ACUKCEFC", "ACUKCEFC", JdeDataType.Numeric),
        new JdeField("ACUKCECP", "ACUKCECP", JdeDataType.Numeric),
        new JdeField("ACUKCEPT", "ACUKCEPT", JdeDataType.String, 2),
        new JdeField("ACUKCEPD", "ACUKCEPD", JdeDataType.Numeric),
        new JdeField("ACICU", "ACICU", JdeDataType.Numeric),
        new JdeField("ACUKURRF", "ACUKURRF", JdeDataType.String, 30),
        new JdeField("ACUKURDT", "ACUKURDT", JdeDataType.Numeric),
        new JdeField("ACUKURC1", "ACUKURC1", JdeDataType.String, 6),
        new JdeField("ACUKURAT", "ACUKURAT", JdeDataType.Numeric),
        new JdeField("ACUKURAB", "ACUKURAB", JdeDataType.Numeric),
        new JdeField("ACUKCEST", "ACUKCEST", JdeDataType.String, 2),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0141_0", "Primary Key on ACDOCO, ACDCTO, ACKCOO, ACSFXO, ACLNID, ACNLIN, ACMATC, ACUKAPNM", new[] { "ACDOCO", "ACDCTO", "ACKCOO", "ACSFXO", "ACLNID", "ACNLIN", "ACMATC", "ACUKAPNM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0141_2", "Index on ACDOCO, ACDCTO, ACKCOO, ACSFXO", new[] { "ACDOCO", "ACDCTO", "ACKCOO", "ACSFXO" }),
        new JdeIndex("F74U0141_3", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACLNID, ACUKCENM", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACLNID", "ACUKCENM" }),
        new JdeIndex("F74U0141_4", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACLNID, ACNLIN, ACUKAPNM, ACUKCENM", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACLNID", "ACNLIN", "ACUKAPNM", "ACUKCENM" }),
        new JdeIndex("F74U0141_5", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACLNID, ACNLIN, ACMATC", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACLNID", "ACNLIN", "ACMATC" }),
        new JdeIndex("F74U0141_6", "Index on ACKCOO, ACDOCO, ACDCTO, ACSFXO, ACLNID, ACMATC", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACSFXO", "ACLNID", "ACMATC" }),
        new JdeIndex("F74U0141_7", "Index on ACKCOO, ACDOCO, ACDCTO, ACUKAPNM", new[] { "ACKCOO", "ACDOCO", "ACDCTO", "ACUKAPNM" })
    };
}
