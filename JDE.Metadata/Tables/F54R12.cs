using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R12 - .
/// </summary>
public class F54R12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRKCOO.
        /// </summary>
        public const string RRKCOO = "RRKCOO";

        /// <summary>
        /// RRDOCO.
        /// </summary>
        public const string RRDOCO = "RRDOCO";

        /// <summary>
        /// RRDCTO.
        /// </summary>
        public const string RRDCTO = "RRDCTO";

        /// <summary>
        /// RRSFXO.
        /// </summary>
        public const string RRSFXO = "RRSFXO";

        /// <summary>
        /// RRLNID.
        /// </summary>
        public const string RRLNID = "RRLNID";

        /// <summary>
        /// RRNLIN.
        /// </summary>
        public const string RRNLIN = "RRNLIN";

        /// <summary>
        /// RRITM.
        /// </summary>
        public const string RRITM = "RRITM";

        /// <summary>
        /// RRLITM.
        /// </summary>
        public const string RRLITM = "RRLITM";

        /// <summary>
        /// RRIMCU.
        /// </summary>
        public const string RRIMCU = "RRIMCU";

        /// <summary>
        /// RRLOCN.
        /// </summary>
        public const string RRLOCN = "RRLOCN";

        /// <summary>
        /// RRLOTN.
        /// </summary>
        public const string RRLOTN = "RRLOTN";

        /// <summary>
        /// RRLOT.
        /// </summary>
        public const string RRLOT = "RRLOT";

        /// <summary>
        /// RRTRDJ.
        /// </summary>
        public const string RRTRDJ = "RRTRDJ";

        /// <summary>
        /// RRRCDJ.
        /// </summary>
        public const string RRRCDJ = "RRRCDJ";

        /// <summary>
        /// RRDRQJ.
        /// </summary>
        public const string RRDRQJ = "RRDRQJ";

        /// <summary>
        /// RRLNTY.
        /// </summary>
        public const string RRLNTY = "RRLNTY";

        /// <summary>
        /// RRMCU.
        /// </summary>
        public const string RRMCU = "RRMCU";

        /// <summary>
        /// RRUREC.
        /// </summary>
        public const string RRUREC = "RRUREC";

        /// <summary>
        /// RRQTYW.
        /// </summary>
        public const string RRQTYW = "RRQTYW";

        /// <summary>
        /// RRQTYC.
        /// </summary>
        public const string RRQTYC = "RRQTYC";

        /// <summary>
        /// RRQTYS.
        /// </summary>
        public const string RRQTYS = "RRQTYS";

        /// <summary>
        /// RRQTYJ.
        /// </summary>
        public const string RRQTYJ = "RRQTYJ";

        /// <summary>
        /// RRUOM3.
        /// </summary>
        public const string RRUOM3 = "RRUOM3";

        /// <summary>
        /// RRUOM.
        /// </summary>
        public const string RRUOM = "RRUOM";

        /// <summary>
        /// RRURCD.
        /// </summary>
        public const string RRURCD = "RRURCD";

        /// <summary>
        /// RRURDT.
        /// </summary>
        public const string RRURDT = "RRURDT";

        /// <summary>
        /// RRURAB.
        /// </summary>
        public const string RRURAB = "RRURAB";

        /// <summary>
        /// RRURRF.
        /// </summary>
        public const string RRURRF = "RRURRF";

        /// <summary>
        /// RRTORG.
        /// </summary>
        public const string RRTORG = "RRTORG";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRJOBN.
        /// </summary>
        public const string RRJOBN = "RRJOBN";

        /// <summary>
        /// RRUPMJ.
        /// </summary>
        public const string RRUPMJ = "RRUPMJ";

        /// <summary>
        /// RRUPMT.
        /// </summary>
        public const string RRUPMT = "RRUPMT";

        /// <summary>
        /// RRMKEY.
        /// </summary>
        public const string RRMKEY = "RRMKEY";

        /// <summary>
        /// RRENTJ.
        /// </summary>
        public const string RRENTJ = "RRENTJ";

        /// <summary>
        /// RR54RRCO.
        /// </summary>
        public const string RR54RRCO = "RR54RRCO";

        /// <summary>
        /// RR54RRLND.
        /// </summary>
        public const string RR54RRLND = "RR54RRLND";

        /// <summary>
        /// RR54RRORN.
        /// </summary>
        public const string RR54RRORN = "RR54RRORN";

        /// <summary>
        /// RR54RRSFX.
        /// </summary>
        public const string RR54RRSFX = "RR54RRSFX";

        /// <summary>
        /// RR54RRCTO.
        /// </summary>
        public const string RR54RRCTO = "RR54RRCTO";

        /// <summary>
        /// RR54RDCD.
        /// </summary>
        public const string RR54RDCD = "RR54RDCD";

        /// <summary>
        /// RRLID0.
        /// </summary>
        public const string RRLID0 = "RRLID0";

        /// <summary>
        /// RRMATC.
        /// </summary>
        public const string RRMATC = "RRMATC";

        /// <summary>
        /// RR54RQTYO.
        /// </summary>
        public const string RR54RQTYO = "RR54RQTYO";

        /// <summary>
        /// RR54RLNID.
        /// </summary>
        public const string RR54RLNID = "RR54RLNID";
    }

    /// <inheritdoc />
    public override string TableName => "F54R12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRKCOO", "RRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RRDOCO", "RRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RRDCTO", "RRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RRSFXO", "RRSFXO", JdeDataType.String, 6),
        new JdeField("RRLNID", "RRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RRNLIN", "RRNLIN", JdeDataType.Numeric),
        new JdeField("RRITM", "RRITM", JdeDataType.Numeric),
        new JdeField("RRLITM", "RRLITM", JdeDataType.String, 50),
        new JdeField("RRIMCU", "RRIMCU", JdeDataType.String, 24),
        new JdeField("RRLOCN", "RRLOCN", JdeDataType.String, 40),
        new JdeField("RRLOTN", "RRLOTN", JdeDataType.String, 60),
        new JdeField("RRLOT", "RRLOT", JdeDataType.String, 60),
        new JdeField("RRTRDJ", "RRTRDJ", JdeDataType.Numeric),
        new JdeField("RRRCDJ", "RRRCDJ", JdeDataType.Numeric),
        new JdeField("RRDRQJ", "RRDRQJ", JdeDataType.Numeric),
        new JdeField("RRLNTY", "RRLNTY", JdeDataType.String, 4),
        new JdeField("RRMCU", "RRMCU", JdeDataType.String, 24),
        new JdeField("RRUREC", "RRUREC", JdeDataType.Numeric),
        new JdeField("RRQTYW", "RRQTYW", JdeDataType.Numeric),
        new JdeField("RRQTYC", "RRQTYC", JdeDataType.Numeric),
        new JdeField("RRQTYS", "RRQTYS", JdeDataType.Numeric),
        new JdeField("RRQTYJ", "RRQTYJ", JdeDataType.Numeric),
        new JdeField("RRUOM3", "RRUOM3", JdeDataType.String, 4),
        new JdeField("RRUOM", "RRUOM", JdeDataType.String, 4),
        new JdeField("RRURCD", "RRURCD", JdeDataType.String, 4),
        new JdeField("RRURDT", "RRURDT", JdeDataType.Numeric),
        new JdeField("RRURAB", "RRURAB", JdeDataType.Numeric),
        new JdeField("RRURRF", "RRURRF", JdeDataType.String, 30),
        new JdeField("RRTORG", "RRTORG", JdeDataType.String, 20),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRJOBN", "RRJOBN", JdeDataType.String, 20),
        new JdeField("RRUPMJ", "RRUPMJ", JdeDataType.Numeric),
        new JdeField("RRUPMT", "RRUPMT", JdeDataType.Numeric),
        new JdeField("RRMKEY", "RRMKEY", JdeDataType.String, 30),
        new JdeField("RRENTJ", "RRENTJ", JdeDataType.Numeric),
        new JdeField("RR54RRCO", "RR54RRCO", JdeDataType.String, 10),
        new JdeField("RR54RRLND", "RR54RRLND", JdeDataType.Numeric),
        new JdeField("RR54RRORN", "RR54RRORN", JdeDataType.String, 16),
        new JdeField("RR54RRSFX", "RR54RRSFX", JdeDataType.String, 6),
        new JdeField("RR54RRCTO", "RR54RRCTO", JdeDataType.String, 4),
        new JdeField("RR54RDCD", "RR54RDCD", JdeDataType.Numeric),
        new JdeField("RRLID0", "RRLID0", JdeDataType.Numeric),
        new JdeField("RRMATC", "RRMATC", JdeDataType.String, 2),
        new JdeField("RR54RQTYO", "RR54RQTYO", JdeDataType.Numeric),
        new JdeField("RR54RLNID", "RR54RLNID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R12_0", "Primary Key on RRLNID, RRDOCO, RRDCTO, RRKCOO, RR54RLNID", new[] { "RRLNID", "RRDOCO", "RRDCTO", "RRKCOO", "RR54RLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R12_2", "Index on RRRCDJ, RRLNID, RRDOCO, RRKCOO, RRDCTO, RR54RLNID, RRUREC", new[] { "RRRCDJ", "RRLNID", "RRDOCO", "RRKCOO", "RRDCTO", "RR54RLNID", "RRUREC" }),
        new JdeIndex("F54R12_3", "Index on SYS_NC00047$, SYS_NC00048$, RRDOCO, RRKCOO, RRDCTO, RR54RLNID, RRUREC", new[] { "SYS_NC00047$", "SYS_NC00048$", "RRDOCO", "RRKCOO", "RRDCTO", "RR54RLNID", "RRUREC" })
    };
}
