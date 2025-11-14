using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4715 - .
/// </summary>
public class F4715 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDEDTY.
        /// </summary>
        public const string ZDEDTY = "ZDEDTY";

        /// <summary>
        /// ZDEDSQ.
        /// </summary>
        public const string ZDEDSQ = "ZDEDSQ";

        /// <summary>
        /// ZDEKCO.
        /// </summary>
        public const string ZDEKCO = "ZDEKCO";

        /// <summary>
        /// ZDEDOC.
        /// </summary>
        public const string ZDEDOC = "ZDEDOC";

        /// <summary>
        /// ZDEDCT.
        /// </summary>
        public const string ZDEDCT = "ZDEDCT";

        /// <summary>
        /// ZDEDLN.
        /// </summary>
        public const string ZDEDLN = "ZDEDLN";

        /// <summary>
        /// ZDEDSP.
        /// </summary>
        public const string ZDEDSP = "ZDEDSP";

        /// <summary>
        /// ZDEDBT.
        /// </summary>
        public const string ZDEDBT = "ZDEDBT";

        /// <summary>
        /// ZDFILE.
        /// </summary>
        public const string ZDFILE = "ZDFILE";

        /// <summary>
        /// ZDKCOO.
        /// </summary>
        public const string ZDKCOO = "ZDKCOO";

        /// <summary>
        /// ZDDOCO.
        /// </summary>
        public const string ZDDOCO = "ZDDOCO";

        /// <summary>
        /// ZDDCTO.
        /// </summary>
        public const string ZDDCTO = "ZDDCTO";

        /// <summary>
        /// ZDLNID.
        /// </summary>
        public const string ZDLNID = "ZDLNID";

        /// <summary>
        /// ZDPNTC.
        /// </summary>
        public const string ZDPNTC = "ZDPNTC";

        /// <summary>
        /// ZDLINS.
        /// </summary>
        public const string ZDLINS = "ZDLINS";

        /// <summary>
        /// ZDTXLN.
        /// </summary>
        public const string ZDTXLN = "ZDTXLN";

        /// <summary>
        /// ZDTORG.
        /// </summary>
        public const string ZDTORG = "ZDTORG";

        /// <summary>
        /// ZDUSER.
        /// </summary>
        public const string ZDUSER = "ZDUSER";

        /// <summary>
        /// ZDPID.
        /// </summary>
        public const string ZDPID = "ZDPID";

        /// <summary>
        /// ZDJOBN.
        /// </summary>
        public const string ZDJOBN = "ZDJOBN";

        /// <summary>
        /// ZDUPMJ.
        /// </summary>
        public const string ZDUPMJ = "ZDUPMJ";

        /// <summary>
        /// ZDTDAY.
        /// </summary>
        public const string ZDTDAY = "ZDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4715";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDEDTY", "ZDEDTY", JdeDataType.String, 2),
        new JdeField("ZDEDSQ", "ZDEDSQ", JdeDataType.Numeric),
        new JdeField("ZDEKCO", "ZDEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ZDEDOC", "ZDEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDEDCT", "ZDEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ZDEDLN", "ZDEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDEDSP", "ZDEDSP", JdeDataType.String, 2),
        new JdeField("ZDEDBT", "ZDEDBT", JdeDataType.String, 30),
        new JdeField("ZDFILE", "ZDFILE", JdeDataType.String, 20, true, true),
        new JdeField("ZDKCOO", "ZDKCOO", JdeDataType.String, 10),
        new JdeField("ZDDOCO", "ZDDOCO", JdeDataType.Numeric),
        new JdeField("ZDDCTO", "ZDDCTO", JdeDataType.String, 4),
        new JdeField("ZDLNID", "ZDLNID", JdeDataType.Numeric),
        new JdeField("ZDPNTC", "ZDPNTC", JdeDataType.String, 2),
        new JdeField("ZDLINS", "ZDLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDTXLN", "ZDTXLN", JdeDataType.String, 120),
        new JdeField("ZDTORG", "ZDTORG", JdeDataType.String, 20),
        new JdeField("ZDUSER", "ZDUSER", JdeDataType.String, 20),
        new JdeField("ZDPID", "ZDPID", JdeDataType.String, 20),
        new JdeField("ZDJOBN", "ZDJOBN", JdeDataType.String, 20),
        new JdeField("ZDUPMJ", "ZDUPMJ", JdeDataType.Numeric),
        new JdeField("ZDTDAY", "ZDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4715_0", "Primary Key on ZDFILE, ZDEDOC, ZDEDCT, ZDEKCO, ZDEDLN, ZDLINS", new[] { "ZDFILE", "ZDEDOC", "ZDEDCT", "ZDEKCO", "ZDEDLN", "ZDLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
