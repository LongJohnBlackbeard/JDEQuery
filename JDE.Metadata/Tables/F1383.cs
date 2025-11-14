using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1383 - .
/// </summary>
public class F1383 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECEQGP.
        /// </summary>
        public const string ECEQGP = "ECEQGP";

        /// <summary>
        /// ECEQSP.
        /// </summary>
        public const string ECEQSP = "ECEQSP";

        /// <summary>
        /// ECSEQ.
        /// </summary>
        public const string ECSEQ = "ECSEQ";

        /// <summary>
        /// ECNUMB.
        /// </summary>
        public const string ECNUMB = "ECNUMB";

        /// <summary>
        /// ECAAID.
        /// </summary>
        public const string ECAAID = "ECAAID";

        /// <summary>
        /// ECAID.
        /// </summary>
        public const string ECAID = "ECAID";

        /// <summary>
        /// ECSBL.
        /// </summary>
        public const string ECSBL = "ECSBL";

        /// <summary>
        /// ECSBLT.
        /// </summary>
        public const string ECSBLT = "ECSBLT";

        /// <summary>
        /// ECLT.
        /// </summary>
        public const string ECLT = "ECLT";

        /// <summary>
        /// ECSMTP.
        /// </summary>
        public const string ECSMTP = "ECSMTP";

        /// <summary>
        /// ECAPID.
        /// </summary>
        public const string ECAPID = "ECAPID";

        /// <summary>
        /// ECASID.
        /// </summary>
        public const string ECASID = "ECASID";

        /// <summary>
        /// ECLVDT.
        /// </summary>
        public const string ECLVDT = "ECLVDT";

        /// <summary>
        /// ECDTFR.
        /// </summary>
        public const string ECDTFR = "ECDTFR";

        /// <summary>
        /// ECDTTO.
        /// </summary>
        public const string ECDTTO = "ECDTTO";

        /// <summary>
        /// ECEXAS.
        /// </summary>
        public const string ECEXAS = "ECEXAS";

        /// <summary>
        /// ECCO.
        /// </summary>
        public const string ECCO = "ECCO";

        /// <summary>
        /// ECMCU.
        /// </summary>
        public const string ECMCU = "ECMCU";

        /// <summary>
        /// ECOBJ.
        /// </summary>
        public const string ECOBJ = "ECOBJ";

        /// <summary>
        /// ECSUB.
        /// </summary>
        public const string ECSUB = "ECSUB";

        /// <summary>
        /// ECCHCD.
        /// </summary>
        public const string ECCHCD = "ECCHCD";

        /// <summary>
        /// ECCCFC.
        /// </summary>
        public const string ECCCFC = "ECCCFC";

        /// <summary>
        /// ECCRCD.
        /// </summary>
        public const string ECCRCD = "ECCRCD";

        /// <summary>
        /// ECFAYTD.
        /// </summary>
        public const string ECFAYTD = "ECFAYTD";

        /// <summary>
        /// ECFAITD.
        /// </summary>
        public const string ECFAITD = "ECFAITD";

        /// <summary>
        /// ECFAPTD.
        /// </summary>
        public const string ECFAPTD = "ECFAPTD";

        /// <summary>
        /// ECAFTD.
        /// </summary>
        public const string ECAFTD = "ECAFTD";

        /// <summary>
        /// ECRAYTD.
        /// </summary>
        public const string ECRAYTD = "ECRAYTD";

        /// <summary>
        /// ECRAITD.
        /// </summary>
        public const string ECRAITD = "ECRAITD";

        /// <summary>
        /// ECRAPTD.
        /// </summary>
        public const string ECRAPTD = "ECRAPTD";

        /// <summary>
        /// ECRAFTD.
        /// </summary>
        public const string ECRAFTD = "ECRAFTD";

        /// <summary>
        /// ECUPMT.
        /// </summary>
        public const string ECUPMT = "ECUPMT";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";

        /// <summary>
        /// ECMKEY.
        /// </summary>
        public const string ECMKEY = "ECMKEY";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1383";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECEQGP", "ECEQGP", JdeDataType.String, 60, true, true),
        new JdeField("ECEQSP", "ECEQSP", JdeDataType.String, 60, true, true),
        new JdeField("ECSEQ", "ECSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ECNUMB", "ECNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("ECAAID", "ECAAID", JdeDataType.Numeric),
        new JdeField("ECAID", "ECAID", JdeDataType.String, 16, true, true),
        new JdeField("ECSBL", "ECSBL", JdeDataType.String, 16, true, true),
        new JdeField("ECSBLT", "ECSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ECLT", "ECLT", JdeDataType.String, 4, true, true),
        new JdeField("ECSMTP", "ECSMTP", JdeDataType.String, 2, true, true),
        new JdeField("ECAPID", "ECAPID", JdeDataType.String, 24),
        new JdeField("ECASID", "ECASID", JdeDataType.String, 50),
        new JdeField("ECLVDT", "ECLVDT", JdeDataType.Numeric),
        new JdeField("ECDTFR", "ECDTFR", JdeDataType.Numeric),
        new JdeField("ECDTTO", "ECDTTO", JdeDataType.Numeric),
        new JdeField("ECEXAS", "ECEXAS", JdeDataType.String, 2),
        new JdeField("ECCO", "ECCO", JdeDataType.String, 10),
        new JdeField("ECMCU", "ECMCU", JdeDataType.String, 24),
        new JdeField("ECOBJ", "ECOBJ", JdeDataType.String, 12),
        new JdeField("ECSUB", "ECSUB", JdeDataType.String, 16),
        new JdeField("ECCHCD", "ECCHCD", JdeDataType.String, 2),
        new JdeField("ECCCFC", "ECCCFC", JdeDataType.String, 4),
        new JdeField("ECCRCD", "ECCRCD", JdeDataType.String, 6),
        new JdeField("ECFAYTD", "ECFAYTD", JdeDataType.Numeric),
        new JdeField("ECFAITD", "ECFAITD", JdeDataType.Numeric),
        new JdeField("ECFAPTD", "ECFAPTD", JdeDataType.Numeric),
        new JdeField("ECAFTD", "ECAFTD", JdeDataType.Numeric),
        new JdeField("ECRAYTD", "ECRAYTD", JdeDataType.Numeric),
        new JdeField("ECRAITD", "ECRAITD", JdeDataType.Numeric),
        new JdeField("ECRAPTD", "ECRAPTD", JdeDataType.Numeric),
        new JdeField("ECRAFTD", "ECRAFTD", JdeDataType.Numeric),
        new JdeField("ECUPMT", "ECUPMT", JdeDataType.Numeric),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20),
        new JdeField("ECMKEY", "ECMKEY", JdeDataType.String, 30),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1383_0", "Primary Key on ECEQGP, ECEQSP, ECSEQ, ECNUMB, ECAID, ECSBL, ECSBLT, ECLT, ECSMTP", new[] { "ECEQGP", "ECEQSP", "ECSEQ", "ECNUMB", "ECAID", "ECSBL", "ECSBLT", "ECLT", "ECSMTP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1383_3", "Index on ECEQGP, ECEQSP, ECSMTP, ECAID, ECLT", new[] { "ECEQGP", "ECEQSP", "ECSMTP", "ECAID", "ECLT" }),
        new JdeIndex("F1383_5", "Index on ECEQGP, ECEQSP, ECLT, ECSMTP", new[] { "ECEQGP", "ECEQSP", "ECLT", "ECSMTP" }),
        new JdeIndex("F1383_7", "Index on ECEQGP, ECEQSP, ECSEQ, ECNUMB, ECSMTP, ECCCFC", new[] { "ECEQGP", "ECEQSP", "ECSEQ", "ECNUMB", "ECSMTP", "ECCCFC" }),
        new JdeIndex("F1383_8", "Index on ECEQGP, ECEQSP, ECSEQ, ECNUMB, ECSBL, ECSBLT, ECSMTP, ECCCFC", new[] { "ECEQGP", "ECEQSP", "ECSEQ", "ECNUMB", "ECSBL", "ECSBLT", "ECSMTP", "ECCCFC" })
    };
}
