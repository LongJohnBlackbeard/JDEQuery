using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI94 - .
/// </summary>
public class F75IUI94 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCDOCO.
        /// </summary>
        public const string TCDOCO = "TCDOCO";

        /// <summary>
        /// TCDCTO.
        /// </summary>
        public const string TCDCTO = "TCDCTO";

        /// <summary>
        /// TCKCOO.
        /// </summary>
        public const string TCKCOO = "TCKCOO";

        /// <summary>
        /// TCLNID.
        /// </summary>
        public const string TCLNID = "TCLNID";

        /// <summary>
        /// TCUITM.
        /// </summary>
        public const string TCUITM = "TCUITM";

        /// <summary>
        /// TCI75CATTY.
        /// </summary>
        public const string TCI75CATTY = "TCI75CATTY";

        /// <summary>
        /// TCI75CATVL.
        /// </summary>
        public const string TCI75CATVL = "TCI75CATVL";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";

        /// <summary>
        /// TCJOBS.
        /// </summary>
        public const string TCJOBS = "TCJOBS";

        /// <summary>
        /// TCYFUTDT1.
        /// </summary>
        public const string TCYFUTDT1 = "TCYFUTDT1";

        /// <summary>
        /// TCFUT6.
        /// </summary>
        public const string TCFUT6 = "TCFUT6";

        /// <summary>
        /// TCYT04.
        /// </summary>
        public const string TCYT04 = "TCYT04";

        /// <summary>
        /// TCYFLAG.
        /// </summary>
        public const string TCYFLAG = "TCYFLAG";

        /// <summary>
        /// TCYNUM1.
        /// </summary>
        public const string TCYNUM1 = "TCYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI94";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCDOCO", "TCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TCDCTO", "TCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TCKCOO", "TCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TCLNID", "TCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TCUITM", "TCUITM", JdeDataType.String, 52),
        new JdeField("TCI75CATTY", "TCI75CATTY", JdeDataType.String, 6),
        new JdeField("TCI75CATVL", "TCI75CATVL", JdeDataType.String, 40),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20, true, true),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric),
        new JdeField("TCJOBS", "TCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TCYFUTDT1", "TCYFUTDT1", JdeDataType.Numeric),
        new JdeField("TCFUT6", "TCFUT6", JdeDataType.String, 60),
        new JdeField("TCYT04", "TCYT04", JdeDataType.String, 2),
        new JdeField("TCYFLAG", "TCYFLAG", JdeDataType.String, 2),
        new JdeField("TCYNUM1", "TCYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI94_0", "Primary Key on TCDOCO, TCDCTO, TCKCOO, TCLNID, TCUSER, TCJOBS", new[] { "TCDOCO", "TCDCTO", "TCKCOO", "TCLNID", "TCUSER", "TCJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
