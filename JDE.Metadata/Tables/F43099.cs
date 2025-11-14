using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43099 - .
/// </summary>
public class F43099 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// POUOM.
        /// </summary>
        public const string POUOM = "POUOM";

        /// <summary>
        /// POQTYM.
        /// </summary>
        public const string POQTYM = "POQTYM";

        /// <summary>
        /// POOPRF.
        /// </summary>
        public const string POOPRF = "POOPRF";

        /// <summary>
        /// POOPRT.
        /// </summary>
        public const string POOPRT = "POOPRT";

        /// <summary>
        /// POMCDE.
        /// </summary>
        public const string POMCDE = "POMCDE";

        /// <summary>
        /// PORCD.
        /// </summary>
        public const string PORCD = "PORCD";

        /// <summary>
        /// PORPL.
        /// </summary>
        public const string PORPL = "PORPL";

        /// <summary>
        /// POPOLN.
        /// </summary>
        public const string POPOLN = "POPOLN";

        /// <summary>
        /// PORVS.
        /// </summary>
        public const string PORVS = "PORVS";

        /// <summary>
        /// PORVSN.
        /// </summary>
        public const string PORVSN = "PORVSN";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";

        /// <summary>
        /// POTDAY.
        /// </summary>
        public const string POTDAY = "POTDAY";

        /// <summary>
        /// POMCU.
        /// </summary>
        public const string POMCU = "POMCU";

        /// <summary>
        /// POITM.
        /// </summary>
        public const string POITM = "POITM";

        /// <summary>
        /// POKCO.
        /// </summary>
        public const string POKCO = "POKCO";

        /// <summary>
        /// PODOC.
        /// </summary>
        public const string PODOC = "PODOC";

        /// <summary>
        /// PODCT.
        /// </summary>
        public const string PODCT = "PODCT";

        /// <summary>
        /// PODGL.
        /// </summary>
        public const string PODGL = "PODGL";

        /// <summary>
        /// POITIS.
        /// </summary>
        public const string POITIS = "POITIS";

        /// <summary>
        /// POVPEJ.
        /// </summary>
        public const string POVPEJ = "POVPEJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43099";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POKCOO", "POKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PODOCO", "PODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PODCTO", "PODCTO", JdeDataType.String, 4, true, true),
        new JdeField("POSFXO", "POSFXO", JdeDataType.String, 6, true, true),
        new JdeField("POLNID", "POLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PONLIN", "PONLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("POUOM", "POUOM", JdeDataType.String, 4),
        new JdeField("POQTYM", "POQTYM", JdeDataType.Numeric),
        new JdeField("POOPRF", "POOPRF", JdeDataType.String, 8),
        new JdeField("POOPRT", "POOPRT", JdeDataType.String, 8),
        new JdeField("POMCDE", "POMCDE", JdeDataType.String, 6, true, true),
        new JdeField("PORCD", "PORCD", JdeDataType.String, 6),
        new JdeField("PORPL", "PORPL", JdeDataType.String, 2),
        new JdeField("POPOLN", "POPOLN", JdeDataType.Numeric),
        new JdeField("PORVS", "PORVS", JdeDataType.String, 2),
        new JdeField("PORVSN", "PORVSN", JdeDataType.Numeric),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("POTDAY", "POTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("POMCU", "POMCU", JdeDataType.String, 24),
        new JdeField("POITM", "POITM", JdeDataType.Numeric),
        new JdeField("POKCO", "POKCO", JdeDataType.String, 10),
        new JdeField("PODOC", "PODOC", JdeDataType.Numeric),
        new JdeField("PODCT", "PODCT", JdeDataType.String, 4),
        new JdeField("PODGL", "PODGL", JdeDataType.Numeric),
        new JdeField("POITIS", "POITIS", JdeDataType.String, 2),
        new JdeField("POVPEJ", "POVPEJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43099_0", "Primary Key on PODOCO, PODCTO, POKCOO, POSFXO, POLNID, PONLIN, POUPMJ, POTDAY, POMCDE", new[] { "PODOCO", "PODCTO", "POKCOO", "POSFXO", "POLNID", "PONLIN", "POUPMJ", "POTDAY", "POMCDE" }, isUnique: true, isPrimaryKey: true)
    };
}
