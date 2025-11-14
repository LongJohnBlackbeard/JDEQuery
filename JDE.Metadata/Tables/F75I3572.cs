using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3572 - .
/// </summary>
public class F75I3572 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSYCHL.
        /// </summary>
        public const string CSYCHL = "CSYCHL";

        /// <summary>
        /// CSMCU0.
        /// </summary>
        public const string CSMCU0 = "CSMCU0";

        /// <summary>
        /// CSYEXU.
        /// </summary>
        public const string CSYEXU = "CSYEXU";

        /// <summary>
        /// CSDOCO.
        /// </summary>
        public const string CSDOCO = "CSDOCO";

        /// <summary>
        /// CSDCTO.
        /// </summary>
        public const string CSDCTO = "CSDCTO";

        /// <summary>
        /// CSKCOO.
        /// </summary>
        public const string CSKCOO = "CSKCOO";

        /// <summary>
        /// CSKCO.
        /// </summary>
        public const string CSKCO = "CSKCO";

        /// <summary>
        /// CSDOC.
        /// </summary>
        public const string CSDOC = "CSDOC";

        /// <summary>
        /// CSDCT.
        /// </summary>
        public const string CSDCT = "CSDCT";

        /// <summary>
        /// CSMCU.
        /// </summary>
        public const string CSMCU = "CSMCU";

        /// <summary>
        /// CSRKCO.
        /// </summary>
        public const string CSRKCO = "CSRKCO";

        /// <summary>
        /// CSRORN.
        /// </summary>
        public const string CSRORN = "CSRORN";

        /// <summary>
        /// CSRCTO.
        /// </summary>
        public const string CSRCTO = "CSRCTO";

        /// <summary>
        /// CSMCUX.
        /// </summary>
        public const string CSMCUX = "CSMCUX";

        /// <summary>
        /// CSTRDJ.
        /// </summary>
        public const string CSTRDJ = "CSTRDJ";

        /// <summary>
        /// CSPRFR.
        /// </summary>
        public const string CSPRFR = "CSPRFR";

        /// <summary>
        /// CSUMGP.
        /// </summary>
        public const string CSUMGP = "CSUMGP";

        /// <summary>
        /// CSAQTY.
        /// </summary>
        public const string CSAQTY = "CSAQTY";

        /// <summary>
        /// CSASVL.
        /// </summary>
        public const string CSASVL = "CSASVL";

        /// <summary>
        /// CSYTDU.
        /// </summary>
        public const string CSYTDU = "CSYTDU";

        /// <summary>
        /// CSDTYS.
        /// </summary>
        public const string CSDTYS = "CSDTYS";

        /// <summary>
        /// CSFLAG.
        /// </summary>
        public const string CSFLAG = "CSFLAG";

        /// <summary>
        /// CSASID.
        /// </summary>
        public const string CSASID = "CSASID";

        /// <summary>
        /// CSUFLG.
        /// </summary>
        public const string CSUFLG = "CSUFLG";

        /// <summary>
        /// CSQTY1.
        /// </summary>
        public const string CSQTY1 = "CSQTY1";

        /// <summary>
        /// CSQTY2.
        /// </summary>
        public const string CSQTY2 = "CSQTY2";

        /// <summary>
        /// CSCRCD.
        /// </summary>
        public const string CSCRCD = "CSCRCD";

        /// <summary>
        /// CSCRDC.
        /// </summary>
        public const string CSCRDC = "CSCRDC";

        /// <summary>
        /// CSYUTD.
        /// </summary>
        public const string CSYUTD = "CSYUTD";

        /// <summary>
        /// CSLFDJ.
        /// </summary>
        public const string CSLFDJ = "CSLFDJ";

        /// <summary>
        /// CSPSDJ.
        /// </summary>
        public const string CSPSDJ = "CSPSDJ";

        /// <summary>
        /// CSDT.
        /// </summary>
        public const string CSDT = "CSDT";

        /// <summary>
        /// CSDT1.
        /// </summary>
        public const string CSDT1 = "CSDT1";

        /// <summary>
        /// CSF1A.
        /// </summary>
        public const string CSF1A = "CSF1A";

        /// <summary>
        /// CSF2A.
        /// </summary>
        public const string CSF2A = "CSF2A";

        /// <summary>
        /// CSF3A.
        /// </summary>
        public const string CSF3A = "CSF3A";

        /// <summary>
        /// CSF4A.
        /// </summary>
        public const string CSF4A = "CSF4A";

        /// <summary>
        /// CSC1FU.
        /// </summary>
        public const string CSC1FU = "CSC1FU";

        /// <summary>
        /// CSC2FU.
        /// </summary>
        public const string CSC2FU = "CSC2FU";

        /// <summary>
        /// CSOPT.
        /// </summary>
        public const string CSOPT = "CSOPT";

        /// <summary>
        /// CSF1T.
        /// </summary>
        public const string CSF1T = "CSF1T";

        /// <summary>
        /// CSF2T.
        /// </summary>
        public const string CSF2T = "CSF2T";

        /// <summary>
        /// CSF3T.
        /// </summary>
        public const string CSF3T = "CSF3T";

        /// <summary>
        /// CSACC.
        /// </summary>
        public const string CSACC = "CSACC";

        /// <summary>
        /// CSANS.
        /// </summary>
        public const string CSANS = "CSANS";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";

        /// <summary>
        /// CSEF01.
        /// </summary>
        public const string CSEF01 = "CSEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3572";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSYCHL", "CSYCHL", JdeDataType.Numeric, null, true, true),
        new JdeField("CSMCU0", "CSMCU0", JdeDataType.String, 24, true, true),
        new JdeField("CSYEXU", "CSYEXU", JdeDataType.Numeric),
        new JdeField("CSDOCO", "CSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CSDCTO", "CSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CSKCOO", "CSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CSKCO", "CSKCO", JdeDataType.String, 10),
        new JdeField("CSDOC", "CSDOC", JdeDataType.Numeric),
        new JdeField("CSDCT", "CSDCT", JdeDataType.String, 4),
        new JdeField("CSMCU", "CSMCU", JdeDataType.String, 24),
        new JdeField("CSRKCO", "CSRKCO", JdeDataType.String, 10),
        new JdeField("CSRORN", "CSRORN", JdeDataType.String, 16),
        new JdeField("CSRCTO", "CSRCTO", JdeDataType.String, 4),
        new JdeField("CSMCUX", "CSMCUX", JdeDataType.String, 24),
        new JdeField("CSTRDJ", "CSTRDJ", JdeDataType.Numeric),
        new JdeField("CSPRFR", "CSPRFR", JdeDataType.String, 4),
        new JdeField("CSUMGP", "CSUMGP", JdeDataType.String, 4),
        new JdeField("CSAQTY", "CSAQTY", JdeDataType.Numeric),
        new JdeField("CSASVL", "CSASVL", JdeDataType.Numeric),
        new JdeField("CSYTDU", "CSYTDU", JdeDataType.Numeric),
        new JdeField("CSDTYS", "CSDTYS", JdeDataType.String, 4),
        new JdeField("CSFLAG", "CSFLAG", JdeDataType.String, 2),
        new JdeField("CSASID", "CSASID", JdeDataType.String, 50),
        new JdeField("CSUFLG", "CSUFLG", JdeDataType.String, 2),
        new JdeField("CSQTY1", "CSQTY1", JdeDataType.Numeric),
        new JdeField("CSQTY2", "CSQTY2", JdeDataType.Numeric),
        new JdeField("CSCRCD", "CSCRCD", JdeDataType.String, 6),
        new JdeField("CSCRDC", "CSCRDC", JdeDataType.String, 6),
        new JdeField("CSYUTD", "CSYUTD", JdeDataType.Numeric),
        new JdeField("CSLFDJ", "CSLFDJ", JdeDataType.Numeric),
        new JdeField("CSPSDJ", "CSPSDJ", JdeDataType.Numeric),
        new JdeField("CSDT", "CSDT", JdeDataType.Numeric),
        new JdeField("CSDT1", "CSDT1", JdeDataType.Numeric),
        new JdeField("CSF1A", "CSF1A", JdeDataType.Numeric),
        new JdeField("CSF2A", "CSF2A", JdeDataType.Numeric),
        new JdeField("CSF3A", "CSF3A", JdeDataType.Numeric),
        new JdeField("CSF4A", "CSF4A", JdeDataType.Numeric),
        new JdeField("CSC1FU", "CSC1FU", JdeDataType.String, 2),
        new JdeField("CSC2FU", "CSC2FU", JdeDataType.String, 2),
        new JdeField("CSOPT", "CSOPT", JdeDataType.String, 2),
        new JdeField("CSF1T", "CSF1T", JdeDataType.String, 60),
        new JdeField("CSF2T", "CSF2T", JdeDataType.String, 60),
        new JdeField("CSF3T", "CSF3T", JdeDataType.String, 60),
        new JdeField("CSACC", "CSACC", JdeDataType.String, 32),
        new JdeField("CSANS", "CSANS", JdeDataType.String, 50),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric),
        new JdeField("CSEF01", "CSEF01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3572_0", "Primary Key on CSYCHL, CSMCU0, CSDOCO, CSDCTO, CSKCOO", new[] { "CSYCHL", "CSMCU0", "CSDOCO", "CSDCTO", "CSKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
