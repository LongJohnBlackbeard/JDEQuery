using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I831 - .
/// </summary>
public class F75I831 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASPYID.
        /// </summary>
        public const string ASPYID = "ASPYID";

        /// <summary>
        /// ASRC5.
        /// </summary>
        public const string ASRC5 = "ASRC5";

        /// <summary>
        /// ASCO.
        /// </summary>
        public const string ASCO = "ASCO";

        /// <summary>
        /// ASAN8.
        /// </summary>
        public const string ASAN8 = "ASAN8";

        /// <summary>
        /// ASMCU.
        /// </summary>
        public const string ASMCU = "ASMCU";

        /// <summary>
        /// ASCKNU.
        /// </summary>
        public const string ASCKNU = "ASCKNU";

        /// <summary>
        /// ASBCRC.
        /// </summary>
        public const string ASBCRC = "ASBCRC";

        /// <summary>
        /// ASCRR.
        /// </summary>
        public const string ASCRR = "ASCRR";

        /// <summary>
        /// ASI75CATTY.
        /// </summary>
        public const string ASI75CATTY = "ASI75CATTY";

        /// <summary>
        /// ASI75CATVL.
        /// </summary>
        public const string ASI75CATVL = "ASI75CATVL";

        /// <summary>
        /// ASAG.
        /// </summary>
        public const string ASAG = "ASAG";

        /// <summary>
        /// ASSTAM.
        /// </summary>
        public const string ASSTAM = "ASSTAM";

        /// <summary>
        /// ASI75CATCO.
        /// </summary>
        public const string ASI75CATCO = "ASI75CATCO";

        /// <summary>
        /// ASATXA.
        /// </summary>
        public const string ASATXA = "ASATXA";

        /// <summary>
        /// ASI75IGSTR.
        /// </summary>
        public const string ASI75IGSTR = "ASI75IGSTR";

        /// <summary>
        /// ASI75IGSTA.
        /// </summary>
        public const string ASI75IGSTA = "ASI75IGSTA";

        /// <summary>
        /// ASI75IGSTO.
        /// </summary>
        public const string ASI75IGSTO = "ASI75IGSTO";

        /// <summary>
        /// ASI75CGSTR.
        /// </summary>
        public const string ASI75CGSTR = "ASI75CGSTR";

        /// <summary>
        /// ASI75CGSTA.
        /// </summary>
        public const string ASI75CGSTA = "ASI75CGSTA";

        /// <summary>
        /// ASI75CGSTO.
        /// </summary>
        public const string ASI75CGSTO = "ASI75CGSTO";

        /// <summary>
        /// ASI75SGSTR.
        /// </summary>
        public const string ASI75SGSTR = "ASI75SGSTR";

        /// <summary>
        /// ASI75SGSTA.
        /// </summary>
        public const string ASI75SGSTA = "ASI75SGSTA";

        /// <summary>
        /// ASI75SGSTO.
        /// </summary>
        public const string ASI75SGSTO = "ASI75SGSTO";

        /// <summary>
        /// ASI75ATX1R.
        /// </summary>
        public const string ASI75ATX1R = "ASI75ATX1R";

        /// <summary>
        /// ASI75ATX1A.
        /// </summary>
        public const string ASI75ATX1A = "ASI75ATX1A";

        /// <summary>
        /// ASI75ATX1O.
        /// </summary>
        public const string ASI75ATX1O = "ASI75ATX1O";

        /// <summary>
        /// ASI75ATX2R.
        /// </summary>
        public const string ASI75ATX2R = "ASI75ATX2R";

        /// <summary>
        /// ASI75ATX2A.
        /// </summary>
        public const string ASI75ATX2A = "ASI75ATX2A";

        /// <summary>
        /// ASI75ATX2O.
        /// </summary>
        public const string ASI75ATX2O = "ASI75ATX2O";

        /// <summary>
        /// ASI75ATX3R.
        /// </summary>
        public const string ASI75ATX3R = "ASI75ATX3R";

        /// <summary>
        /// ASI75ATX3A.
        /// </summary>
        public const string ASI75ATX3A = "ASI75ATX3A";

        /// <summary>
        /// ASI75ATX3O.
        /// </summary>
        public const string ASI75ATX3O = "ASI75ATX3O";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASJOBN.
        /// </summary>
        public const string ASJOBN = "ASJOBN";

        /// <summary>
        /// ASUPMJ.
        /// </summary>
        public const string ASUPMJ = "ASUPMJ";

        /// <summary>
        /// ASUPMT.
        /// </summary>
        public const string ASUPMT = "ASUPMT";

        /// <summary>
        /// ASYFUTDT1.
        /// </summary>
        public const string ASYFUTDT1 = "ASYFUTDT1";

        /// <summary>
        /// ASFUT6.
        /// </summary>
        public const string ASFUT6 = "ASFUT6";

        /// <summary>
        /// ASYT04.
        /// </summary>
        public const string ASYT04 = "ASYT04";

        /// <summary>
        /// ASYFLAG.
        /// </summary>
        public const string ASYFLAG = "ASYFLAG";

        /// <summary>
        /// ASYNUM1.
        /// </summary>
        public const string ASYNUM1 = "ASYNUM1";

        /// <summary>
        /// ASICU.
        /// </summary>
        public const string ASICU = "ASICU";

        /// <summary>
        /// ASICUT.
        /// </summary>
        public const string ASICUT = "ASICUT";

        /// <summary>
        /// ASI75CESSA.
        /// </summary>
        public const string ASI75CESSA = "ASI75CESSA";

        /// <summary>
        /// ASI75CESSR.
        /// </summary>
        public const string ASI75CESSR = "ASI75CESSR";

        /// <summary>
        /// ASI75CESSO.
        /// </summary>
        public const string ASI75CESSO = "ASI75CESSO";

        /// <summary>
        /// ASI75AT4A.
        /// </summary>
        public const string ASI75AT4A = "ASI75AT4A";

        /// <summary>
        /// ASI75AT4R.
        /// </summary>
        public const string ASI75AT4R = "ASI75AT4R";

        /// <summary>
        /// ASI75AT4O.
        /// </summary>
        public const string ASI75AT4O = "ASI75AT4O";

        /// <summary>
        /// ASI75GSTRA.
        /// </summary>
        public const string ASI75GSTRA = "ASI75GSTRA";

        /// <summary>
        /// ASI75TRCAT.
        /// </summary>
        public const string ASI75TRCAT = "ASI75TRCAT";

        /// <summary>
        /// ASI75IPOS.
        /// </summary>
        public const string ASI75IPOS = "ASI75IPOS";

        /// <summary>
        /// ASI75GCATG.
        /// </summary>
        public const string ASI75GCATG = "ASI75GCATG";

        /// <summary>
        /// ASI75REMK.
        /// </summary>
        public const string ASI75REMK = "ASI75REMK";

        /// <summary>
        /// ASI75BDLU.
        /// </summary>
        public const string ASI75BDLU = "ASI75BDLU";
    }

    /// <inheritdoc />
    public override string TableName => "F75I831";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASPYID", "ASPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("ASRC5", "ASRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("ASCO", "ASCO", JdeDataType.String, 10),
        new JdeField("ASAN8", "ASAN8", JdeDataType.Numeric),
        new JdeField("ASMCU", "ASMCU", JdeDataType.String, 24),
        new JdeField("ASCKNU", "ASCKNU", JdeDataType.String, 50),
        new JdeField("ASBCRC", "ASBCRC", JdeDataType.String, 6),
        new JdeField("ASCRR", "ASCRR", JdeDataType.Numeric),
        new JdeField("ASI75CATTY", "ASI75CATTY", JdeDataType.String, 6),
        new JdeField("ASI75CATVL", "ASI75CATVL", JdeDataType.String, 40, true, true),
        new JdeField("ASAG", "ASAG", JdeDataType.Numeric),
        new JdeField("ASSTAM", "ASSTAM", JdeDataType.Numeric),
        new JdeField("ASI75CATCO", "ASI75CATCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ASATXA", "ASATXA", JdeDataType.Numeric),
        new JdeField("ASI75IGSTR", "ASI75IGSTR", JdeDataType.Numeric),
        new JdeField("ASI75IGSTA", "ASI75IGSTA", JdeDataType.Numeric),
        new JdeField("ASI75IGSTO", "ASI75IGSTO", JdeDataType.Numeric),
        new JdeField("ASI75CGSTR", "ASI75CGSTR", JdeDataType.Numeric),
        new JdeField("ASI75CGSTA", "ASI75CGSTA", JdeDataType.Numeric),
        new JdeField("ASI75CGSTO", "ASI75CGSTO", JdeDataType.Numeric),
        new JdeField("ASI75SGSTR", "ASI75SGSTR", JdeDataType.Numeric),
        new JdeField("ASI75SGSTA", "ASI75SGSTA", JdeDataType.Numeric),
        new JdeField("ASI75SGSTO", "ASI75SGSTO", JdeDataType.Numeric),
        new JdeField("ASI75ATX1R", "ASI75ATX1R", JdeDataType.Numeric),
        new JdeField("ASI75ATX1A", "ASI75ATX1A", JdeDataType.Numeric),
        new JdeField("ASI75ATX1O", "ASI75ATX1O", JdeDataType.Numeric),
        new JdeField("ASI75ATX2R", "ASI75ATX2R", JdeDataType.Numeric),
        new JdeField("ASI75ATX2A", "ASI75ATX2A", JdeDataType.Numeric),
        new JdeField("ASI75ATX2O", "ASI75ATX2O", JdeDataType.Numeric),
        new JdeField("ASI75ATX3R", "ASI75ATX3R", JdeDataType.Numeric),
        new JdeField("ASI75ATX3A", "ASI75ATX3A", JdeDataType.Numeric),
        new JdeField("ASI75ATX3O", "ASI75ATX3O", JdeDataType.Numeric),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASJOBN", "ASJOBN", JdeDataType.String, 20),
        new JdeField("ASUPMJ", "ASUPMJ", JdeDataType.Numeric),
        new JdeField("ASUPMT", "ASUPMT", JdeDataType.Numeric),
        new JdeField("ASYFUTDT1", "ASYFUTDT1", JdeDataType.Numeric),
        new JdeField("ASFUT6", "ASFUT6", JdeDataType.String, 60),
        new JdeField("ASYT04", "ASYT04", JdeDataType.String, 2),
        new JdeField("ASYFLAG", "ASYFLAG", JdeDataType.String, 2),
        new JdeField("ASYNUM1", "ASYNUM1", JdeDataType.Numeric),
        new JdeField("ASICU", "ASICU", JdeDataType.Numeric),
        new JdeField("ASICUT", "ASICUT", JdeDataType.String, 4),
        new JdeField("ASI75CESSA", "ASI75CESSA", JdeDataType.Numeric),
        new JdeField("ASI75CESSR", "ASI75CESSR", JdeDataType.Numeric),
        new JdeField("ASI75CESSO", "ASI75CESSO", JdeDataType.Numeric),
        new JdeField("ASI75AT4A", "ASI75AT4A", JdeDataType.Numeric),
        new JdeField("ASI75AT4R", "ASI75AT4R", JdeDataType.Numeric),
        new JdeField("ASI75AT4O", "ASI75AT4O", JdeDataType.Numeric),
        new JdeField("ASI75GSTRA", "ASI75GSTRA", JdeDataType.String, 4),
        new JdeField("ASI75TRCAT", "ASI75TRCAT", JdeDataType.String, 4),
        new JdeField("ASI75IPOS", "ASI75IPOS", JdeDataType.String, 4),
        new JdeField("ASI75GCATG", "ASI75GCATG", JdeDataType.String, 4),
        new JdeField("ASI75REMK", "ASI75REMK", JdeDataType.String, 60),
        new JdeField("ASI75BDLU", "ASI75BDLU", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I831_0", "Primary Key on ASPYID, ASRC5, ASI75CATVL, ASI75CATCO", new[] { "ASPYID", "ASRC5", "ASI75CATVL", "ASI75CATCO" }, isUnique: true, isPrimaryKey: true)
    };
}
