using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4305 - .
/// </summary>
public class F4305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLUKID.
        /// </summary>
        public const string PLUKID = "PLUKID";

        /// <summary>
        /// PLLOGH.
        /// </summary>
        public const string PLLOGH = "PLLOGH";

        /// <summary>
        /// PLDOCO.
        /// </summary>
        public const string PLDOCO = "PLDOCO";

        /// <summary>
        /// PLDCTO.
        /// </summary>
        public const string PLDCTO = "PLDCTO";

        /// <summary>
        /// PLKCOO.
        /// </summary>
        public const string PLKCOO = "PLKCOO";

        /// <summary>
        /// PLSFXO.
        /// </summary>
        public const string PLSFXO = "PLSFXO";

        /// <summary>
        /// PLAN8.
        /// </summary>
        public const string PLAN8 = "PLAN8";

        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLOMCU.
        /// </summary>
        public const string PLOMCU = "PLOMCU";

        /// <summary>
        /// PLLGTY.
        /// </summary>
        public const string PLLGTY = "PLLGTY";

        /// <summary>
        /// PLLGNO.
        /// </summary>
        public const string PLLGNO = "PLLGNO";

        /// <summary>
        /// PLDL01.
        /// </summary>
        public const string PLDL01 = "PLDL01";

        /// <summary>
        /// PLSTSC.
        /// </summary>
        public const string PLSTSC = "PLSTSC";

        /// <summary>
        /// PLEXR.
        /// </summary>
        public const string PLEXR = "PLEXR";

        /// <summary>
        /// PLPAYE.
        /// </summary>
        public const string PLPAYE = "PLPAYE";

        /// <summary>
        /// PLISSU.
        /// </summary>
        public const string PLISSU = "PLISSU";

        /// <summary>
        /// PLEXPR.
        /// </summary>
        public const string PLEXPR = "PLEXPR";

        /// <summary>
        /// PLREQR.
        /// </summary>
        public const string PLREQR = "PLREQR";

        /// <summary>
        /// PLDEJ.
        /// </summary>
        public const string PLDEJ = "PLDEJ";

        /// <summary>
        /// PLANCR.
        /// </summary>
        public const string PLANCR = "PLANCR";

        /// <summary>
        /// PLCONO.
        /// </summary>
        public const string PLCONO = "PLCONO";

        /// <summary>
        /// PLRPT1.
        /// </summary>
        public const string PLRPT1 = "PLRPT1";

        /// <summary>
        /// PLRPT2.
        /// </summary>
        public const string PLRPT2 = "PLRPT2";

        /// <summary>
        /// PLRPT3.
        /// </summary>
        public const string PLRPT3 = "PLRPT3";

        /// <summary>
        /// PLSBCD.
        /// </summary>
        public const string PLSBCD = "PLSBCD";

        /// <summary>
        /// PLU.
        /// </summary>
        public const string PLU = "PLU";

        /// <summary>
        /// PLUM.
        /// </summary>
        public const string PLUM = "PLUM";

        /// <summary>
        /// PLUSD1.
        /// </summary>
        public const string PLUSD1 = "PLUSD1";

        /// <summary>
        /// PLCO.
        /// </summary>
        public const string PLCO = "PLCO";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLUKID", "PLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLLOGH", "PLLOGH", JdeDataType.String, 4),
        new JdeField("PLDOCO", "PLDOCO", JdeDataType.Numeric),
        new JdeField("PLDCTO", "PLDCTO", JdeDataType.String, 4),
        new JdeField("PLKCOO", "PLKCOO", JdeDataType.String, 10),
        new JdeField("PLSFXO", "PLSFXO", JdeDataType.String, 6),
        new JdeField("PLAN8", "PLAN8", JdeDataType.Numeric),
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24),
        new JdeField("PLOMCU", "PLOMCU", JdeDataType.String, 24),
        new JdeField("PLLGTY", "PLLGTY", JdeDataType.String, 2),
        new JdeField("PLLGNO", "PLLGNO", JdeDataType.Numeric),
        new JdeField("PLDL01", "PLDL01", JdeDataType.String, 60),
        new JdeField("PLSTSC", "PLSTSC", JdeDataType.String, 2),
        new JdeField("PLEXR", "PLEXR", JdeDataType.String, 60),
        new JdeField("PLPAYE", "PLPAYE", JdeDataType.String, 2),
        new JdeField("PLISSU", "PLISSU", JdeDataType.Numeric),
        new JdeField("PLEXPR", "PLEXPR", JdeDataType.Numeric),
        new JdeField("PLREQR", "PLREQR", JdeDataType.Numeric),
        new JdeField("PLDEJ", "PLDEJ", JdeDataType.Numeric),
        new JdeField("PLANCR", "PLANCR", JdeDataType.Numeric),
        new JdeField("PLCONO", "PLCONO", JdeDataType.Numeric),
        new JdeField("PLRPT1", "PLRPT1", JdeDataType.String, 6),
        new JdeField("PLRPT2", "PLRPT2", JdeDataType.String, 6),
        new JdeField("PLRPT3", "PLRPT3", JdeDataType.String, 6),
        new JdeField("PLSBCD", "PLSBCD", JdeDataType.String, 2),
        new JdeField("PLU", "PLU", JdeDataType.Numeric),
        new JdeField("PLUM", "PLUM", JdeDataType.String, 4),
        new JdeField("PLUSD1", "PLUSD1", JdeDataType.Numeric),
        new JdeField("PLCO", "PLCO", JdeDataType.String, 10),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4305_0", "Primary Key on PLUKID", new[] { "PLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4305_2", "Index on PLLOGH, PLKCOO, PLDOCO, PLDCTO, PLREQR, PLEXPR", new[] { "PLLOGH", "PLKCOO", "PLDOCO", "PLDCTO", "PLREQR", "PLEXPR" }),
        new JdeIndex("F4305_3", "Index on PLLOGH, PLAN8", new[] { "PLLOGH", "PLAN8" }),
        new JdeIndex("F4305_4", "Index on PLLOGH, PLMCU", new[] { "PLLOGH", "PLMCU" }),
        new JdeIndex("F4305_5", "Index on PLLOGH, PLOMCU", new[] { "PLLOGH", "PLOMCU" })
    };
}
