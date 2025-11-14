using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q411 - .
/// </summary>
public class F43Q411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// REEVNU.
        /// </summary>
        public const string REEVNU = "REEVNU";

        /// <summary>
        /// REDCTO.
        /// </summary>
        public const string REDCTO = "REDCTO";

        /// <summary>
        /// REKCOO.
        /// </summary>
        public const string REKCOO = "REKCOO";

        /// <summary>
        /// REEVLN.
        /// </summary>
        public const string REEVLN = "REEVLN";

        /// <summary>
        /// REBIDNUM.
        /// </summary>
        public const string REBIDNUM = "REBIDNUM";

        /// <summary>
        /// REBIDQN.
        /// </summary>
        public const string REBIDQN = "REBIDQN";

        /// <summary>
        /// REAN8.
        /// </summary>
        public const string REAN8 = "REAN8";

        /// <summary>
        /// RERDLN.
        /// </summary>
        public const string RERDLN = "RERDLN";

        /// <summary>
        /// REBRQD.
        /// </summary>
        public const string REBRQD = "REBRQD";

        /// <summary>
        /// RERBQ.
        /// </summary>
        public const string RERBQ = "RERBQ";

        /// <summary>
        /// REBIDCODE.
        /// </summary>
        public const string REBIDCODE = "REBIDCODE";

        /// <summary>
        /// REDESC.
        /// </summary>
        public const string REDESC = "REDESC";

        /// <summary>
        /// REBQTYP.
        /// </summary>
        public const string REBQTYP = "REBQTYP";

        /// <summary>
        /// REMORS.
        /// </summary>
        public const string REMORS = "REMORS";

        /// <summary>
        /// REFMORS.
        /// </summary>
        public const string REFMORS = "REFMORS";

        /// <summary>
        /// REPRESP.
        /// </summary>
        public const string REPRESP = "REPRESP";

        /// <summary>
        /// REFPRESP.
        /// </summary>
        public const string REFPRESP = "REFPRESP";

        /// <summary>
        /// REQRSP.
        /// </summary>
        public const string REQRSP = "REQRSP";

        /// <summary>
        /// REDTERESP.
        /// </summary>
        public const string REDTERESP = "REDTERESP";

        /// <summary>
        /// RETXTR.
        /// </summary>
        public const string RETXTR = "RETXTR";

        /// <summary>
        /// REYNR.
        /// </summary>
        public const string REYNR = "REYNR";

        /// <summary>
        /// RELIRS.
        /// </summary>
        public const string RELIRS = "RELIRS";

        /// <summary>
        /// RELLNR.
        /// </summary>
        public const string RELLNR = "RELLNR";

        /// <summary>
        /// REDISBDQ.
        /// </summary>
        public const string REDISBDQ = "REDISBDQ";

        /// <summary>
        /// RERSCR.
        /// </summary>
        public const string RERSCR = "RERSCR";

        /// <summary>
        /// RECRCD.
        /// </summary>
        public const string RECRCD = "RECRCD";

        /// <summary>
        /// REPCMPT.
        /// </summary>
        public const string REPCMPT = "REPCMPT";

        /// <summary>
        /// READTRC.
        /// </summary>
        public const string READTRC = "READTRC";

        /// <summary>
        /// REURCD.
        /// </summary>
        public const string REURCD = "REURCD";

        /// <summary>
        /// REURDT.
        /// </summary>
        public const string REURDT = "REURDT";

        /// <summary>
        /// REURAT.
        /// </summary>
        public const string REURAT = "REURAT";

        /// <summary>
        /// REURAB.
        /// </summary>
        public const string REURAB = "REURAB";

        /// <summary>
        /// REURRF.
        /// </summary>
        public const string REURRF = "REURRF";

        /// <summary>
        /// RETORG.
        /// </summary>
        public const string RETORG = "RETORG";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REPID.
        /// </summary>
        public const string REPID = "REPID";

        /// <summary>
        /// REJOBN.
        /// </summary>
        public const string REJOBN = "REJOBN";

        /// <summary>
        /// REUPMJ.
        /// </summary>
        public const string REUPMJ = "REUPMJ";

        /// <summary>
        /// RETDAY.
        /// </summary>
        public const string RETDAY = "RETDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("REEVNU", "REEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("REDCTO", "REDCTO", JdeDataType.String, 4, true, true),
        new JdeField("REKCOO", "REKCOO", JdeDataType.String, 10, true, true),
        new JdeField("REEVLN", "REEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("REBIDNUM", "REBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("REBIDQN", "REBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("REAN8", "REAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RERDLN", "RERDLN", JdeDataType.Numeric),
        new JdeField("REBRQD", "REBRQD", JdeDataType.String, 2),
        new JdeField("RERBQ", "RERBQ", JdeDataType.String, 2),
        new JdeField("REBIDCODE", "REBIDCODE", JdeDataType.String, 36),
        new JdeField("REDESC", "REDESC", JdeDataType.String, 60),
        new JdeField("REBQTYP", "REBQTYP", JdeDataType.String, 4),
        new JdeField("REMORS", "REMORS", JdeDataType.Numeric),
        new JdeField("REFMORS", "REFMORS", JdeDataType.Numeric),
        new JdeField("REPRESP", "REPRESP", JdeDataType.Numeric),
        new JdeField("REFPRESP", "REFPRESP", JdeDataType.Numeric),
        new JdeField("REQRSP", "REQRSP", JdeDataType.Numeric),
        new JdeField("REDTERESP", "REDTERESP", JdeDataType.Numeric),
        new JdeField("RETXTR", "RETXTR", JdeDataType.String, 3998),
        new JdeField("REYNR", "REYNR", JdeDataType.String, 2),
        new JdeField("RELIRS", "RELIRS", JdeDataType.String, 110),
        new JdeField("RELLNR", "RELLNR", JdeDataType.Numeric),
        new JdeField("REDISBDQ", "REDISBDQ", JdeDataType.String, 2),
        new JdeField("RERSCR", "RERSCR", JdeDataType.Numeric),
        new JdeField("RECRCD", "RECRCD", JdeDataType.String, 6),
        new JdeField("REPCMPT", "REPCMPT", JdeDataType.String, 2),
        new JdeField("READTRC", "READTRC", JdeDataType.String, 2000),
        new JdeField("REURCD", "REURCD", JdeDataType.String, 4),
        new JdeField("REURDT", "REURDT", JdeDataType.Numeric),
        new JdeField("REURAT", "REURAT", JdeDataType.Numeric),
        new JdeField("REURAB", "REURAB", JdeDataType.Numeric),
        new JdeField("REURRF", "REURRF", JdeDataType.String, 30),
        new JdeField("RETORG", "RETORG", JdeDataType.String, 20),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REPID", "REPID", JdeDataType.String, 20),
        new JdeField("REJOBN", "REJOBN", JdeDataType.String, 20),
        new JdeField("REUPMJ", "REUPMJ", JdeDataType.Numeric),
        new JdeField("RETDAY", "RETDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q411_0", "Primary Key on REEVNU, REDCTO, REKCOO, REEVLN, REBIDNUM, REBIDQN, REAN8", new[] { "REEVNU", "REDCTO", "REKCOO", "REEVLN", "REBIDNUM", "REBIDQN", "REAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q411_2", "Index on REEVNU, REDCTO, REKCOO, REEVLN, REBIDNUM, REAN8", new[] { "REEVNU", "REDCTO", "REKCOO", "REEVLN", "REBIDNUM", "REAN8" }),
        new JdeIndex("F43Q411_3", "Index on REEVNU, REDCTO, REKCOO, REEVLN, REBIDNUM, REAN8, REBQTYP", new[] { "REEVNU", "REDCTO", "REKCOO", "REEVLN", "REBIDNUM", "REAN8", "REBQTYP" }),
        new JdeIndex("F43Q411_4", "Index on REEVNU, REDCTO, REKCOO, REAN8, REBIDNUM, REEVLN, REBIDQN", new[] { "REEVNU", "REDCTO", "REKCOO", "REAN8", "REBIDNUM", "REEVLN", "REBIDQN" })
    };
}
