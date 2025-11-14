using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5280 - .
/// </summary>
public class F5280 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GWDOCO.
        /// </summary>
        public const string GWDOCO = "GWDOCO";

        /// <summary>
        /// GWDCTO.
        /// </summary>
        public const string GWDCTO = "GWDCTO";

        /// <summary>
        /// GWKCOO.
        /// </summary>
        public const string GWKCOO = "GWKCOO";

        /// <summary>
        /// GWCOCH.
        /// </summary>
        public const string GWCOCH = "GWCOCH";

        /// <summary>
        /// GWLNID.
        /// </summary>
        public const string GWLNID = "GWLNID";

        /// <summary>
        /// GWOPIM.
        /// </summary>
        public const string GWOPIM = "GWOPIM";

        /// <summary>
        /// GWDGL.
        /// </summary>
        public const string GWDGL = "GWDGL";

        /// <summary>
        /// GWPN.
        /// </summary>
        public const string GWPN = "GWPN";

        /// <summary>
        /// GWFY.
        /// </summary>
        public const string GWFY = "GWFY";

        /// <summary>
        /// GWCTRY.
        /// </summary>
        public const string GWCTRY = "GWCTRY";

        /// <summary>
        /// GWCRAM.
        /// </summary>
        public const string GWCRAM = "GWCRAM";

        /// <summary>
        /// GWCRFA.
        /// </summary>
        public const string GWCRFA = "GWCRFA";

        /// <summary>
        /// GWCRUN.
        /// </summary>
        public const string GWCRUN = "GWCRUN";

        /// <summary>
        /// GWCMAM.
        /// </summary>
        public const string GWCMAM = "GWCMAM";

        /// <summary>
        /// GWCMFA.
        /// </summary>
        public const string GWCMFA = "GWCMFA";

        /// <summary>
        /// GWCMUN.
        /// </summary>
        public const string GWCMUN = "GWCMUN";

        /// <summary>
        /// GWCRCD.
        /// </summary>
        public const string GWCRCD = "GWCRCD";

        /// <summary>
        /// GWCRCF.
        /// </summary>
        public const string GWCRCF = "GWCRCF";

        /// <summary>
        /// GWJOBN.
        /// </summary>
        public const string GWJOBN = "GWJOBN";

        /// <summary>
        /// GWPID.
        /// </summary>
        public const string GWPID = "GWPID";

        /// <summary>
        /// GWUSER.
        /// </summary>
        public const string GWUSER = "GWUSER";

        /// <summary>
        /// GWUPMT.
        /// </summary>
        public const string GWUPMT = "GWUPMT";

        /// <summary>
        /// GWUPMJ.
        /// </summary>
        public const string GWUPMJ = "GWUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F5280";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GWDOCO", "GWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("GWDCTO", "GWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("GWKCOO", "GWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("GWCOCH", "GWCOCH", JdeDataType.String, 6, true, true),
        new JdeField("GWLNID", "GWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("GWOPIM", "GWOPIM", JdeDataType.String, 30),
        new JdeField("GWDGL", "GWDGL", JdeDataType.Numeric),
        new JdeField("GWPN", "GWPN", JdeDataType.Numeric, null, true, true),
        new JdeField("GWFY", "GWFY", JdeDataType.Numeric, null, true, true),
        new JdeField("GWCTRY", "GWCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("GWCRAM", "GWCRAM", JdeDataType.Numeric),
        new JdeField("GWCRFA", "GWCRFA", JdeDataType.Numeric),
        new JdeField("GWCRUN", "GWCRUN", JdeDataType.Numeric),
        new JdeField("GWCMAM", "GWCMAM", JdeDataType.Numeric),
        new JdeField("GWCMFA", "GWCMFA", JdeDataType.Numeric),
        new JdeField("GWCMUN", "GWCMUN", JdeDataType.Numeric),
        new JdeField("GWCRCD", "GWCRCD", JdeDataType.String, 6),
        new JdeField("GWCRCF", "GWCRCF", JdeDataType.String, 6),
        new JdeField("GWJOBN", "GWJOBN", JdeDataType.String, 20),
        new JdeField("GWPID", "GWPID", JdeDataType.String, 20),
        new JdeField("GWUSER", "GWUSER", JdeDataType.String, 20),
        new JdeField("GWUPMT", "GWUPMT", JdeDataType.Numeric),
        new JdeField("GWUPMJ", "GWUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5280_0", "Primary Key on GWDOCO, GWDCTO, GWKCOO, GWCOCH, GWLNID, GWCTRY, GWFY, GWPN", new[] { "GWDOCO", "GWDCTO", "GWKCOO", "GWCOCH", "GWLNID", "GWCTRY", "GWFY", "GWPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5280_4", "Index on GWDOCO, GWDCTO, GWKCOO, GWCOCH, GWLNID, SYS_NC00024$", new[] { "GWDOCO", "GWDCTO", "GWKCOO", "GWCOCH", "GWLNID", "SYS_NC00024$" }),
        new JdeIndex("F5280_5", "Index on GWDOCO, GWDCTO, GWKCOO, GWCOCH, GWLNID, SYS_NC00025$, SYS_NC00026$, SYS_NC00027$", new[] { "GWDOCO", "GWDCTO", "GWKCOO", "GWCOCH", "GWLNID", "SYS_NC00025$", "SYS_NC00026$", "SYS_NC00027$" })
    };
}
