using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I839 - .
/// </summary>
public class F75I839 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDPYID.
        /// </summary>
        public const string RDPYID = "RDPYID";

        /// <summary>
        /// RDI75CATVL.
        /// </summary>
        public const string RDI75CATVL = "RDI75CATVL";

        /// <summary>
        /// RDI75CATTY.
        /// </summary>
        public const string RDI75CATTY = "RDI75CATTY";

        /// <summary>
        /// RDI75TXTY.
        /// </summary>
        public const string RDI75TXTY = "RDI75TXTY";

        /// <summary>
        /// RDI75CATCO.
        /// </summary>
        public const string RDI75CATCO = "RDI75CATCO";

        /// <summary>
        /// RDI75TXRL.
        /// </summary>
        public const string RDI75TXRL = "RDI75TXRL";

        /// <summary>
        /// RDI75GSTRA.
        /// </summary>
        public const string RDI75GSTRA = "RDI75GSTRA";

        /// <summary>
        /// RDI75PSP.
        /// </summary>
        public const string RDI75PSP = "RDI75PSP";

        /// <summary>
        /// RDI75PSR.
        /// </summary>
        public const string RDI75PSR = "RDI75PSR";

        /// <summary>
        /// RDI75PROVL.
        /// </summary>
        public const string RDI75PROVL = "RDI75PROVL";

        /// <summary>
        /// RDI75RECVL.
        /// </summary>
        public const string RDI75RECVL = "RDI75RECVL";

        /// <summary>
        /// RDAOPN.
        /// </summary>
        public const string RDAOPN = "RDAOPN";

        /// <summary>
        /// RDSTAM.
        /// </summary>
        public const string RDSTAM = "RDSTAM";

        /// <summary>
        /// RDI75GSTR.
        /// </summary>
        public const string RDI75GSTR = "RDI75GSTR";

        /// <summary>
        /// RDATXA.
        /// </summary>
        public const string RDATXA = "RDATXA";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDYFUTDT1.
        /// </summary>
        public const string RDYFUTDT1 = "RDYFUTDT1";

        /// <summary>
        /// RDFUT6.
        /// </summary>
        public const string RDFUT6 = "RDFUT6";

        /// <summary>
        /// RDYT04.
        /// </summary>
        public const string RDYT04 = "RDYT04";

        /// <summary>
        /// RDYFLAG.
        /// </summary>
        public const string RDYFLAG = "RDYFLAG";

        /// <summary>
        /// RDYNUM1.
        /// </summary>
        public const string RDYNUM1 = "RDYNUM1";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDI75RECU.
        /// </summary>
        public const string RDI75RECU = "RDI75RECU";
    }

    /// <inheritdoc />
    public override string TableName => "F75I839";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDPYID", "RDPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDI75CATVL", "RDI75CATVL", JdeDataType.String, 40, true, true),
        new JdeField("RDI75CATTY", "RDI75CATTY", JdeDataType.String, 6, true, true),
        new JdeField("RDI75TXTY", "RDI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("RDI75CATCO", "RDI75CATCO", JdeDataType.Numeric),
        new JdeField("RDI75TXRL", "RDI75TXRL", JdeDataType.String, 12),
        new JdeField("RDI75GSTRA", "RDI75GSTRA", JdeDataType.String, 4),
        new JdeField("RDI75PSP", "RDI75PSP", JdeDataType.Numeric),
        new JdeField("RDI75PSR", "RDI75PSR", JdeDataType.Numeric),
        new JdeField("RDI75PROVL", "RDI75PROVL", JdeDataType.Numeric),
        new JdeField("RDI75RECVL", "RDI75RECVL", JdeDataType.Numeric),
        new JdeField("RDAOPN", "RDAOPN", JdeDataType.Numeric),
        new JdeField("RDSTAM", "RDSTAM", JdeDataType.Numeric),
        new JdeField("RDI75GSTR", "RDI75GSTR", JdeDataType.Numeric),
        new JdeField("RDATXA", "RDATXA", JdeDataType.Numeric),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDYFUTDT1", "RDYFUTDT1", JdeDataType.Numeric),
        new JdeField("RDFUT6", "RDFUT6", JdeDataType.String, 60),
        new JdeField("RDYT04", "RDYT04", JdeDataType.String, 2),
        new JdeField("RDYFLAG", "RDYFLAG", JdeDataType.String, 2),
        new JdeField("RDYNUM1", "RDYNUM1", JdeDataType.Numeric),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RDI75RECU", "RDI75RECU", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I839_0", "Primary Key on RDPYID, RDAN8, RDI75CATVL, RDI75CATTY, RDI75TXTY", new[] { "RDPYID", "RDAN8", "RDI75CATVL", "RDI75CATTY", "RDI75TXTY" }, isUnique: true, isPrimaryKey: true)
    };
}
