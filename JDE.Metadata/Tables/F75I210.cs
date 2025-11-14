using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I210 - .
/// </summary>
public class F75I210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSADD1.
        /// </summary>
        public const string CSADD1 = "CSADD1";

        /// <summary>
        /// CSADD2.
        /// </summary>
        public const string CSADD2 = "CSADD2";

        /// <summary>
        /// CSADD3.
        /// </summary>
        public const string CSADD3 = "CSADD3";

        /// <summary>
        /// CSADD4.
        /// </summary>
        public const string CSADD4 = "CSADD4";

        /// <summary>
        /// CSADD5.
        /// </summary>
        public const string CSADD5 = "CSADD5";

        /// <summary>
        /// CSADD6.
        /// </summary>
        public const string CSADD6 = "CSADD6";

        /// <summary>
        /// CSI75CERC.
        /// </summary>
        public const string CSI75CERC = "CSI75CERC";

        /// <summary>
        /// CSI75RETY.
        /// </summary>
        public const string CSI75RETY = "CSI75RETY";

        /// <summary>
        /// CSPCAC.
        /// </summary>
        public const string CSPCAC = "CSPCAC";

        /// <summary>
        /// CSI75ECCN.
        /// </summary>
        public const string CSI75ECCN = "CSI75ECCN";

        /// <summary>
        /// CSI75ZONE.
        /// </summary>
        public const string CSI75ZONE = "CSI75ZONE";

        /// <summary>
        /// CSI75REGN.
        /// </summary>
        public const string CSI75REGN = "CSI75REGN";

        /// <summary>
        /// CSI75CIRC.
        /// </summary>
        public const string CSI75CIRC = "CSI75CIRC";

        /// <summary>
        /// CSI75COTR.
        /// </summary>
        public const string CSI75COTR = "CSI75COTR";

        /// <summary>
        /// CSI75RNGE.
        /// </summary>
        public const string CSI75RNGE = "CSI75RNGE";

        /// <summary>
        /// CSD01.
        /// </summary>
        public const string CSD01 = "CSD01";

        /// <summary>
        /// CSD02.
        /// </summary>
        public const string CSD02 = "CSD02";

        /// <summary>
        /// CSD03.
        /// </summary>
        public const string CSD03 = "CSD03";

        /// <summary>
        /// CSD04.
        /// </summary>
        public const string CSD04 = "CSD04";

        /// <summary>
        /// CSD05.
        /// </summary>
        public const string CSD05 = "CSD05";

        /// <summary>
        /// CSD06.
        /// </summary>
        public const string CSD06 = "CSD06";

        /// <summary>
        /// CSI75WCT.
        /// </summary>
        public const string CSI75WCT = "CSI75WCT";

        /// <summary>
        /// CSI75TIN.
        /// </summary>
        public const string CSI75TIN = "CSI75TIN";

        /// <summary>
        /// CSI75SERT.
        /// </summary>
        public const string CSI75SERT = "CSI75SERT";

        /// <summary>
        /// CSI75CST.
        /// </summary>
        public const string CSI75CST = "CSI75CST";

        /// <summary>
        /// CSI75LST.
        /// </summary>
        public const string CSI75LST = "CSI75LST";

        /// <summary>
        /// CSI75DVSN.
        /// </summary>
        public const string CSI75DVSN = "CSI75DVSN";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";

        /// <summary>
        /// CSI75ORAC.
        /// </summary>
        public const string CSI75ORAC = "CSI75ORAC";

        /// <summary>
        /// CSI75AUTH.
        /// </summary>
        public const string CSI75AUTH = "CSI75AUTH";

        /// <summary>
        /// CSI75DSGN.
        /// </summary>
        public const string CSI75DSGN = "CSI75DSGN";

        /// <summary>
        /// CSI75EIC.
        /// </summary>
        public const string CSI75EIC = "CSI75EIC";
    }

    /// <inheritdoc />
    public override string TableName => "F75I210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSADD1", "CSADD1", JdeDataType.String, 80),
        new JdeField("CSADD2", "CSADD2", JdeDataType.String, 80),
        new JdeField("CSADD3", "CSADD3", JdeDataType.String, 80),
        new JdeField("CSADD4", "CSADD4", JdeDataType.String, 80),
        new JdeField("CSADD5", "CSADD5", JdeDataType.String, 80),
        new JdeField("CSADD6", "CSADD6", JdeDataType.String, 80),
        new JdeField("CSI75CERC", "CSI75CERC", JdeDataType.String, 30),
        new JdeField("CSI75RETY", "CSI75RETY", JdeDataType.String, 6),
        new JdeField("CSPCAC", "CSPCAC", JdeDataType.String, 20),
        new JdeField("CSI75ECCN", "CSI75ECCN", JdeDataType.String, 30),
        new JdeField("CSI75ZONE", "CSI75ZONE", JdeDataType.String, 80),
        new JdeField("CSI75REGN", "CSI75REGN", JdeDataType.String, 80),
        new JdeField("CSI75CIRC", "CSI75CIRC", JdeDataType.String, 80),
        new JdeField("CSI75COTR", "CSI75COTR", JdeDataType.String, 80),
        new JdeField("CSI75RNGE", "CSI75RNGE", JdeDataType.String, 80),
        new JdeField("CSD01", "CSD01", JdeDataType.Numeric),
        new JdeField("CSD02", "CSD02", JdeDataType.Numeric),
        new JdeField("CSD03", "CSD03", JdeDataType.Numeric),
        new JdeField("CSD04", "CSD04", JdeDataType.Numeric),
        new JdeField("CSD05", "CSD05", JdeDataType.Numeric),
        new JdeField("CSD06", "CSD06", JdeDataType.Numeric),
        new JdeField("CSI75WCT", "CSI75WCT", JdeDataType.String, 80),
        new JdeField("CSI75TIN", "CSI75TIN", JdeDataType.String, 80),
        new JdeField("CSI75SERT", "CSI75SERT", JdeDataType.String, 30),
        new JdeField("CSI75CST", "CSI75CST", JdeDataType.String, 80),
        new JdeField("CSI75LST", "CSI75LST", JdeDataType.String, 80),
        new JdeField("CSI75DVSN", "CSI75DVSN", JdeDataType.String, 80),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric),
        new JdeField("CSI75ORAC", "CSI75ORAC", JdeDataType.String, 80),
        new JdeField("CSI75AUTH", "CSI75AUTH", JdeDataType.String, 80),
        new JdeField("CSI75DSGN", "CSI75DSGN", JdeDataType.String, 80),
        new JdeField("CSI75EIC", "CSI75EIC", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I210_0", "Primary Key on CSAN8", new[] { "CSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
