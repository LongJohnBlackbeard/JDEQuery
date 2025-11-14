using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E121 - .
/// </summary>
public class F43E121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ERKCOO.
        /// </summary>
        public const string ERKCOO = "ERKCOO";

        /// <summary>
        /// ERDOCO.
        /// </summary>
        public const string ERDOCO = "ERDOCO";

        /// <summary>
        /// ERDCTO.
        /// </summary>
        public const string ERDCTO = "ERDCTO";

        /// <summary>
        /// ERSFXO.
        /// </summary>
        public const string ERSFXO = "ERSFXO";

        /// <summary>
        /// ERLNID.
        /// </summary>
        public const string ERLNID = "ERLNID";

        /// <summary>
        /// ERDOC.
        /// </summary>
        public const string ERDOC = "ERDOC";

        /// <summary>
        /// ERDCT.
        /// </summary>
        public const string ERDCT = "ERDCT";

        /// <summary>
        /// ERANBY.
        /// </summary>
        public const string ERANBY = "ERANBY";

        /// <summary>
        /// ERRORN.
        /// </summary>
        public const string ERRORN = "ERRORN";

        /// <summary>
        /// ERRCTO.
        /// </summary>
        public const string ERRCTO = "ERRCTO";

        /// <summary>
        /// ERRKCO.
        /// </summary>
        public const string ERRKCO = "ERRKCO";

        /// <summary>
        /// ERRLLN.
        /// </summary>
        public const string ERRLLN = "ERRLLN";

        /// <summary>
        /// ERUPMJ.
        /// </summary>
        public const string ERUPMJ = "ERUPMJ";

        /// <summary>
        /// ERUPMT.
        /// </summary>
        public const string ERUPMT = "ERUPMT";

        /// <summary>
        /// ERPID.
        /// </summary>
        public const string ERPID = "ERPID";

        /// <summary>
        /// ERJOBN.
        /// </summary>
        public const string ERJOBN = "ERJOBN";

        /// <summary>
        /// ERMATC.
        /// </summary>
        public const string ERMATC = "ERMATC";

        /// <summary>
        /// ERNLIN.
        /// </summary>
        public const string ERNLIN = "ERNLIN";

        /// <summary>
        /// ERAREQ.
        /// </summary>
        public const string ERAREQ = "ERAREQ";

        /// <summary>
        /// ERUSER.
        /// </summary>
        public const string ERUSER = "ERUSER";

        /// <summary>
        /// ERAREC.
        /// </summary>
        public const string ERAREC = "ERAREC";

        /// <summary>
        /// ERUREC.
        /// </summary>
        public const string ERUREC = "ERUREC";

        /// <summary>
        /// ERUOM.
        /// </summary>
        public const string ERUOM = "ERUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F43E121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ERKCOO", "ERKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ERDOCO", "ERDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ERDCTO", "ERDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ERSFXO", "ERSFXO", JdeDataType.String, 6, true, true),
        new JdeField("ERLNID", "ERLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ERDOC", "ERDOC", JdeDataType.Numeric),
        new JdeField("ERDCT", "ERDCT", JdeDataType.String, 4),
        new JdeField("ERANBY", "ERANBY", JdeDataType.Numeric),
        new JdeField("ERRORN", "ERRORN", JdeDataType.String, 16, true, true),
        new JdeField("ERRCTO", "ERRCTO", JdeDataType.String, 4, true, true),
        new JdeField("ERRKCO", "ERRKCO", JdeDataType.String, 10, true, true),
        new JdeField("ERRLLN", "ERRLLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ERUPMJ", "ERUPMJ", JdeDataType.Numeric),
        new JdeField("ERUPMT", "ERUPMT", JdeDataType.Numeric),
        new JdeField("ERPID", "ERPID", JdeDataType.String, 20),
        new JdeField("ERJOBN", "ERJOBN", JdeDataType.String, 20),
        new JdeField("ERMATC", "ERMATC", JdeDataType.String, 2),
        new JdeField("ERNLIN", "ERNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("ERAREQ", "ERAREQ", JdeDataType.Numeric),
        new JdeField("ERUSER", "ERUSER", JdeDataType.String, 20),
        new JdeField("ERAREC", "ERAREC", JdeDataType.Numeric),
        new JdeField("ERUREC", "ERUREC", JdeDataType.Numeric),
        new JdeField("ERUOM", "ERUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E121_0", "Primary Key on ERDOCO, ERDCTO, ERKCOO, ERSFXO, ERLNID, ERNLIN, ERRORN, ERRCTO, ERRKCO, ERRLLN", new[] { "ERDOCO", "ERDCTO", "ERKCOO", "ERSFXO", "ERLNID", "ERNLIN", "ERRORN", "ERRCTO", "ERRKCO", "ERRLLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E121_2", "Index on ERDOC", new[] { "ERDOC" }),
        new JdeIndex("F43E121_3", "Index on ERKCOO, ERDOCO, ERDCTO, ERSFXO, ERLNID", new[] { "ERKCOO", "ERDOCO", "ERDCTO", "ERSFXO", "ERLNID" }),
        new JdeIndex("F43E121_4", "Index on ERDOCO, ERDCTO, ERKCOO, ERSFXO, ERLNID, ERNLIN", new[] { "ERDOCO", "ERDCTO", "ERKCOO", "ERSFXO", "ERLNID", "ERNLIN" })
    };
}
