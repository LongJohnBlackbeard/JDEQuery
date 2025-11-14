using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I008 - .
/// </summary>
public class F75I008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// POMATC.
        /// </summary>
        public const string POMATC = "POMATC";

        /// <summary>
        /// POKCOO.
        /// </summary>
        public const string POKCOO = "POKCOO";

        /// <summary>
        /// PODOCO.
        /// </summary>
        public const string PODOCO = "PODOCO";

        /// <summary>
        /// PODCTO.
        /// </summary>
        public const string PODCTO = "PODCTO";

        /// <summary>
        /// POSFXO.
        /// </summary>
        public const string POSFXO = "POSFXO";

        /// <summary>
        /// POLNID.
        /// </summary>
        public const string POLNID = "POLNID";

        /// <summary>
        /// PONLIN.
        /// </summary>
        public const string PONLIN = "PONLIN";

        /// <summary>
        /// PODOC.
        /// </summary>
        public const string PODOC = "PODOC";

        /// <summary>
        /// PODCT.
        /// </summary>
        public const string PODCT = "PODCT";

        /// <summary>
        /// POKCO.
        /// </summary>
        public const string POKCO = "POKCO";

        /// <summary>
        /// POPCST.
        /// </summary>
        public const string POPCST = "POPCST";

        /// <summary>
        /// POI75ASVA.
        /// </summary>
        public const string POI75ASVA = "POI75ASVA";

        /// <summary>
        /// POI75TXRG.
        /// </summary>
        public const string POI75TXRG = "POI75TXRG";

        /// <summary>
        /// POI75TXTY.
        /// </summary>
        public const string POI75TXTY = "POI75TXTY";

        /// <summary>
        /// POYEXU.
        /// </summary>
        public const string POYEXU = "POYEXU";

        /// <summary>
        /// POI75RTSU.
        /// </summary>
        public const string POI75RTSU = "POI75RTSU";

        /// <summary>
        /// POI75RTEU.
        /// </summary>
        public const string POI75RTEU = "POI75RTEU";

        /// <summary>
        /// POI75ITTY.
        /// </summary>
        public const string POI75ITTY = "POI75ITTY";

        /// <summary>
        /// POI75RECU.
        /// </summary>
        public const string POI75RECU = "POI75RECU";

        /// <summary>
        /// POI75DEDT.
        /// </summary>
        public const string POI75DEDT = "POI75DEDT";

        /// <summary>
        /// POI75CHEX.
        /// </summary>
        public const string POI75CHEX = "POI75CHEX";

        /// <summary>
        /// POI75CHCD.
        /// </summary>
        public const string POI75CHCD = "POI75CHCD";

        /// <summary>
        /// POI75PRFL.
        /// </summary>
        public const string POI75PRFL = "POI75PRFL";

        /// <summary>
        /// POI75CUHO.
        /// </summary>
        public const string POI75CUHO = "POI75CUHO";

        /// <summary>
        /// POI75ORMA.
        /// </summary>
        public const string POI75ORMA = "POI75ORMA";

        /// <summary>
        /// POI75ORIN.
        /// </summary>
        public const string POI75ORIN = "POI75ORIN";

        /// <summary>
        /// POI75ORID.
        /// </summary>
        public const string POI75ORID = "POI75ORID";

        /// <summary>
        /// POI75ORAD.
        /// </summary>
        public const string POI75ORAD = "POI75ORAD";

        /// <summary>
        /// POI75ORTD.
        /// </summary>
        public const string POI75ORTD = "POI75ORTD";

        /// <summary>
        /// POI75ORQR.
        /// </summary>
        public const string POI75ORQR = "POI75ORQR";

        /// <summary>
        /// POI75ORUM.
        /// </summary>
        public const string POI75ORUM = "POI75ORUM";

        /// <summary>
        /// POI75ORDR.
        /// </summary>
        public const string POI75ORDR = "POI75ORDR";

        /// <summary>
        /// POI75ORCH.
        /// </summary>
        public const string POI75ORCH = "POI75ORCH";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";

        /// <summary>
        /// POUPMT.
        /// </summary>
        public const string POUPMT = "POUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POMATC", "POMATC", JdeDataType.String, 2, true, true),
        new JdeField("POKCOO", "POKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PODOCO", "PODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PODCTO", "PODCTO", JdeDataType.String, 4, true, true),
        new JdeField("POSFXO", "POSFXO", JdeDataType.String, 6, true, true),
        new JdeField("POLNID", "POLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PONLIN", "PONLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PODOC", "PODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PODCT", "PODCT", JdeDataType.String, 4),
        new JdeField("POKCO", "POKCO", JdeDataType.String, 10),
        new JdeField("POPCST", "POPCST", JdeDataType.Numeric),
        new JdeField("POI75ASVA", "POI75ASVA", JdeDataType.Numeric),
        new JdeField("POI75TXRG", "POI75TXRG", JdeDataType.String, 10),
        new JdeField("POI75TXTY", "POI75TXTY", JdeDataType.String, 10),
        new JdeField("POYEXU", "POYEXU", JdeDataType.Numeric),
        new JdeField("POI75RTSU", "POI75RTSU", JdeDataType.String, 6),
        new JdeField("POI75RTEU", "POI75RTEU", JdeDataType.String, 6),
        new JdeField("POI75ITTY", "POI75ITTY", JdeDataType.String, 12),
        new JdeField("POI75RECU", "POI75RECU", JdeDataType.String, 2),
        new JdeField("POI75DEDT", "POI75DEDT", JdeDataType.Numeric),
        new JdeField("POI75CHEX", "POI75CHEX", JdeDataType.String, 40),
        new JdeField("POI75CHCD", "POI75CHCD", JdeDataType.String, 40),
        new JdeField("POI75PRFL", "POI75PRFL", JdeDataType.String, 2),
        new JdeField("POI75CUHO", "POI75CUHO", JdeDataType.String, 80),
        new JdeField("POI75ORMA", "POI75ORMA", JdeDataType.Numeric),
        new JdeField("POI75ORIN", "POI75ORIN", JdeDataType.String, 50),
        new JdeField("POI75ORID", "POI75ORID", JdeDataType.Numeric),
        new JdeField("POI75ORAD", "POI75ORAD", JdeDataType.Numeric),
        new JdeField("POI75ORTD", "POI75ORTD", JdeDataType.Numeric),
        new JdeField("POI75ORQR", "POI75ORQR", JdeDataType.Numeric),
        new JdeField("POI75ORUM", "POI75ORUM", JdeDataType.String, 4),
        new JdeField("POI75ORDR", "POI75ORDR", JdeDataType.Numeric),
        new JdeField("POI75ORCH", "POI75ORCH", JdeDataType.String, 80),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric),
        new JdeField("POUPMT", "POUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I008_0", "Primary Key on POMATC, PODOCO, PODCTO, POKCOO, POSFXO, POLNID, PONLIN, PODOC", new[] { "POMATC", "PODOCO", "PODCTO", "POKCOO", "POSFXO", "POLNID", "PONLIN", "PODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I008_2", "Index on PODOC, PODCT, POKCO", new[] { "PODOC", "PODCT", "POKCO" })
    };
}
