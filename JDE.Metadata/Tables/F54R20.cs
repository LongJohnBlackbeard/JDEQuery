using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R20 - .
/// </summary>
public class F54R20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RODOCO.
        /// </summary>
        public const string RODOCO = "RODOCO";

        /// <summary>
        /// RODCTO.
        /// </summary>
        public const string RODCTO = "RODCTO";

        /// <summary>
        /// ROKCOO.
        /// </summary>
        public const string ROKCOO = "ROKCOO";

        /// <summary>
        /// ROLNID.
        /// </summary>
        public const string ROLNID = "ROLNID";

        /// <summary>
        /// RO54RAN.
        /// </summary>
        public const string RO54RAN = "RO54RAN";

        /// <summary>
        /// RO54RROSTA.
        /// </summary>
        public const string RO54RROSTA = "RO54RROSTA";

        /// <summary>
        /// RO54RSELEC.
        /// </summary>
        public const string RO54RSELEC = "RO54RSELEC";

        /// <summary>
        /// ROMCU.
        /// </summary>
        public const string ROMCU = "ROMCU";

        /// <summary>
        /// RO54RPGM.
        /// </summary>
        public const string RO54RPGM = "RO54RPGM";

        /// <summary>
        /// RO54RVERS.
        /// </summary>
        public const string RO54RVERS = "RO54RVERS";

        /// <summary>
        /// ROADOC.
        /// </summary>
        public const string ROADOC = "ROADOC";

        /// <summary>
        /// ROADR.
        /// </summary>
        public const string ROADR = "ROADR";

        /// <summary>
        /// ROAKCO.
        /// </summary>
        public const string ROAKCO = "ROAKCO";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROUPMT.
        /// </summary>
        public const string ROUPMT = "ROUPMT";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROMKEY.
        /// </summary>
        public const string ROMKEY = "ROMKEY";

        /// <summary>
        /// ROENTJ.
        /// </summary>
        public const string ROENTJ = "ROENTJ";

        /// <summary>
        /// ROTORG.
        /// </summary>
        public const string ROTORG = "ROTORG";

        /// <summary>
        /// ROURCD.
        /// </summary>
        public const string ROURCD = "ROURCD";

        /// <summary>
        /// ROURDT.
        /// </summary>
        public const string ROURDT = "ROURDT";

        /// <summary>
        /// ROURAT.
        /// </summary>
        public const string ROURAT = "ROURAT";

        /// <summary>
        /// ROURAB.
        /// </summary>
        public const string ROURAB = "ROURAB";

        /// <summary>
        /// ROURRF.
        /// </summary>
        public const string ROURRF = "ROURRF";

        /// <summary>
        /// ROTENT.
        /// </summary>
        public const string ROTENT = "ROTENT";

        /// <summary>
        /// RO54TMNG.
        /// </summary>
        public const string RO54TMNG = "RO54TMNG";

        /// <summary>
        /// RO54RUKID.
        /// </summary>
        public const string RO54RUKID = "RO54RUKID";

        /// <summary>
        /// RO54RMNL.
        /// </summary>
        public const string RO54RMNL = "RO54RMNL";

        /// <summary>
        /// RO54RRLND.
        /// </summary>
        public const string RO54RRLND = "RO54RRLND";

        /// <summary>
        /// RO54RQTYP.
        /// </summary>
        public const string RO54RQTYP = "RO54RQTYP";

        /// <summary>
        /// RO54RSTKUP.
        /// </summary>
        public const string RO54RSTKUP = "RO54RSTKUP";
    }

    /// <inheritdoc />
    public override string TableName => "F54R20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RODOCO", "RODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RODCTO", "RODCTO", JdeDataType.String, 4, true, true),
        new JdeField("ROKCOO", "ROKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ROLNID", "ROLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RO54RAN", "RO54RAN", JdeDataType.Numeric, null, true, true),
        new JdeField("RO54RROSTA", "RO54RROSTA", JdeDataType.String, 2),
        new JdeField("RO54RSELEC", "RO54RSELEC", JdeDataType.String, 2),
        new JdeField("ROMCU", "ROMCU", JdeDataType.String, 24),
        new JdeField("RO54RPGM", "RO54RPGM", JdeDataType.String, 20),
        new JdeField("RO54RVERS", "RO54RVERS", JdeDataType.String, 20),
        new JdeField("ROADOC", "ROADOC", JdeDataType.Numeric),
        new JdeField("ROADR", "ROADR", JdeDataType.String, 4),
        new JdeField("ROAKCO", "ROAKCO", JdeDataType.String, 10),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROUPMT", "ROUPMT", JdeDataType.Numeric),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROMKEY", "ROMKEY", JdeDataType.String, 30),
        new JdeField("ROENTJ", "ROENTJ", JdeDataType.Numeric),
        new JdeField("ROTORG", "ROTORG", JdeDataType.String, 20),
        new JdeField("ROURCD", "ROURCD", JdeDataType.String, 4),
        new JdeField("ROURDT", "ROURDT", JdeDataType.Numeric),
        new JdeField("ROURAT", "ROURAT", JdeDataType.Numeric),
        new JdeField("ROURAB", "ROURAB", JdeDataType.Numeric),
        new JdeField("ROURRF", "ROURRF", JdeDataType.String, 30),
        new JdeField("ROTENT", "ROTENT", JdeDataType.Numeric),
        new JdeField("RO54TMNG", "RO54TMNG", JdeDataType.String, 2),
        new JdeField("RO54RUKID", "RO54RUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RO54RMNL", "RO54RMNL", JdeDataType.String, 2),
        new JdeField("RO54RRLND", "RO54RRLND", JdeDataType.Numeric),
        new JdeField("RO54RQTYP", "RO54RQTYP", JdeDataType.Numeric),
        new JdeField("RO54RSTKUP", "RO54RSTKUP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R20_0", "Primary Key on RODOCO, RODCTO, ROKCOO, ROLNID, RO54RAN, RO54RUKID", new[] { "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "RO54RAN", "RO54RUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R20_10", "Index on RODOCO, RODCTO, ROKCOO, RO54RPGM, ROADOC", new[] { "RODOCO", "RODCTO", "ROKCOO", "RO54RPGM", "ROADOC" }),
        new JdeIndex("F54R20_2", "Index on RODOCO, RODCTO, ROKCOO", new[] { "RODOCO", "RODCTO", "ROKCOO" }),
        new JdeIndex("F54R20_3", "Index on RODOCO, RODCTO, ROKCOO, ROLNID", new[] { "RODOCO", "RODCTO", "ROKCOO", "ROLNID" }),
        new JdeIndex("F54R20_4", "Index on RODOCO, RODCTO, ROKCOO, RO54RSELEC", new[] { "RODOCO", "RODCTO", "ROKCOO", "RO54RSELEC" }),
        new JdeIndex("F54R20_5", "Index on RODOCO, RODCTO, ROKCOO, ROLNID, RO54RROSTA", new[] { "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "RO54RROSTA" }),
        new JdeIndex("F54R20_6", "Index on SYS_NC00034$, RODOCO, RODCTO, ROKCOO, ROLNID, RO54RAN", new[] { "SYS_NC00034$", "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "RO54RAN" }),
        new JdeIndex("F54R20_7", "Index on RODOCO, RODCTO, ROKCOO, ROLNID, RO54RUKID", new[] { "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "RO54RUKID" }),
        new JdeIndex("F54R20_8", "Index on RODOCO, RODCTO, ROKCOO, ROLNID, RO54RAN", new[] { "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "RO54RAN" }),
        new JdeIndex("F54R20_9", "Index on RODOCO, RODCTO, ROKCOO, RO54RPGM, RO54RVERS, ROLNID, RO54RAN, RO54RUKID", new[] { "RODOCO", "RODCTO", "ROKCOO", "RO54RPGM", "RO54RVERS", "ROLNID", "RO54RAN", "RO54RUKID" })
    };
}
