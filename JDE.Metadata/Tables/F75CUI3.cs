using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75CUI3 - .
/// </summary>
public class F75CUI3 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWUSER.
        /// </summary>
        public const string CWUSER = "CWUSER";

        /// <summary>
        /// CWPID.
        /// </summary>
        public const string CWPID = "CWPID";

        /// <summary>
        /// CWUPMJ.
        /// </summary>
        public const string CWUPMJ = "CWUPMJ";

        /// <summary>
        /// CWUPMT.
        /// </summary>
        public const string CWUPMT = "CWUPMT";

        /// <summary>
        /// CWJOBN.
        /// </summary>
        public const string CWJOBN = "CWJOBN";

        /// <summary>
        /// CWC75RID.
        /// </summary>
        public const string CWC75RID = "CWC75RID";

        /// <summary>
        /// CWC75SEQN.
        /// </summary>
        public const string CWC75SEQN = "CWC75SEQN";

        /// <summary>
        /// CWC75LNNUM.
        /// </summary>
        public const string CWC75LNNUM = "CWC75LNNUM";

        /// <summary>
        /// CWC75LNDS1.
        /// </summary>
        public const string CWC75LNDS1 = "CWC75LNDS1";

        /// <summary>
        /// CWC75LNDS2.
        /// </summary>
        public const string CWC75LNDS2 = "CWC75LNDS2";

        /// <summary>
        /// CWC75ORN.
        /// </summary>
        public const string CWC75ORN = "CWC75ORN";

        /// <summary>
        /// CWGFL1.
        /// </summary>
        public const string CWGFL1 = "CWGFL1";

        /// <summary>
        /// CWAN01.
        /// </summary>
        public const string CWAN01 = "CWAN01";

        /// <summary>
        /// CWAN02.
        /// </summary>
        public const string CWAN02 = "CWAN02";

        /// <summary>
        /// CWAN03.
        /// </summary>
        public const string CWAN03 = "CWAN03";

        /// <summary>
        /// CWAN04.
        /// </summary>
        public const string CWAN04 = "CWAN04";

        /// <summary>
        /// CWAN05.
        /// </summary>
        public const string CWAN05 = "CWAN05";

        /// <summary>
        /// CWAN06.
        /// </summary>
        public const string CWAN06 = "CWAN06";

        /// <summary>
        /// CWAN07.
        /// </summary>
        public const string CWAN07 = "CWAN07";

        /// <summary>
        /// CWAN08.
        /// </summary>
        public const string CWAN08 = "CWAN08";

        /// <summary>
        /// CWDL01.
        /// </summary>
        public const string CWDL01 = "CWDL01";

        /// <summary>
        /// CWDL02.
        /// </summary>
        public const string CWDL02 = "CWDL02";

        /// <summary>
        /// CWFLAG.
        /// </summary>
        public const string CWFLAG = "CWFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75CUI3";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWUSER", "CWUSER", JdeDataType.String, 20, true, true),
        new JdeField("CWPID", "CWPID", JdeDataType.String, 20),
        new JdeField("CWUPMJ", "CWUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CWUPMT", "CWUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("CWJOBN", "CWJOBN", JdeDataType.String, 20, true, true),
        new JdeField("CWC75RID", "CWC75RID", JdeDataType.String, 6, true, true),
        new JdeField("CWC75SEQN", "CWC75SEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("CWC75LNNUM", "CWC75LNNUM", JdeDataType.Numeric),
        new JdeField("CWC75LNDS1", "CWC75LNDS1", JdeDataType.String, 510),
        new JdeField("CWC75LNDS2", "CWC75LNDS2", JdeDataType.String, 510),
        new JdeField("CWC75ORN", "CWC75ORN", JdeDataType.Numeric),
        new JdeField("CWGFL1", "CWGFL1", JdeDataType.String, 2),
        new JdeField("CWAN01", "CWAN01", JdeDataType.Numeric),
        new JdeField("CWAN02", "CWAN02", JdeDataType.Numeric),
        new JdeField("CWAN03", "CWAN03", JdeDataType.Numeric),
        new JdeField("CWAN04", "CWAN04", JdeDataType.Numeric),
        new JdeField("CWAN05", "CWAN05", JdeDataType.Numeric),
        new JdeField("CWAN06", "CWAN06", JdeDataType.Numeric),
        new JdeField("CWAN07", "CWAN07", JdeDataType.Numeric),
        new JdeField("CWAN08", "CWAN08", JdeDataType.Numeric),
        new JdeField("CWDL01", "CWDL01", JdeDataType.String, 60),
        new JdeField("CWDL02", "CWDL02", JdeDataType.String, 60),
        new JdeField("CWFLAG", "CWFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75CUI3_0", "Primary Key on CWUSER, CWUPMJ, CWUPMT, CWJOBN, CWC75RID, CWC75SEQN", new[] { "CWUSER", "CWUPMJ", "CWUPMT", "CWJOBN", "CWC75RID", "CWC75SEQN" }, isUnique: true, isPrimaryKey: true)
    };
}
