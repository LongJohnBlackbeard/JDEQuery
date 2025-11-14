using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76VLO01 - .
/// </summary>
public class F76VLO01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LODGJ.
        /// </summary>
        public const string LODGJ = "LODGJ";

        /// <summary>
        /// LODCT.
        /// </summary>
        public const string LODCT = "LODCT";

        /// <summary>
        /// LODOC.
        /// </summary>
        public const string LODOC = "LODOC";

        /// <summary>
        /// LOKCO.
        /// </summary>
        public const string LOKCO = "LOKCO";

        /// <summary>
        /// LOFLAG.
        /// </summary>
        public const string LOFLAG = "LOFLAG";

        /// <summary>
        /// LOADID.
        /// </summary>
        public const string LOADID = "LOADID";

        /// <summary>
        /// LOTAX.
        /// </summary>
        public const string LOTAX = "LOTAX";

        /// <summary>
        /// LOAGENT.
        /// </summary>
        public const string LOAGENT = "LOAGENT";

        /// <summary>
        /// LODC20.
        /// </summary>
        public const string LODC20 = "LODC20";

        /// <summary>
        /// LODDES.
        /// </summary>
        public const string LODDES = "LODDES";

        /// <summary>
        /// LOAG.
        /// </summary>
        public const string LOAG = "LOAG";

        /// <summary>
        /// LOATXA.
        /// </summary>
        public const string LOATXA = "LOATXA";

        /// <summary>
        /// LOSTAM.
        /// </summary>
        public const string LOSTAM = "LOSTAM";

        /// <summary>
        /// LOAAP.
        /// </summary>
        public const string LOAAP = "LOAAP";

        /// <summary>
        /// LOALKY.
        /// </summary>
        public const string LOALKY = "LOALKY";

        /// <summary>
        /// LOGPTN.
        /// </summary>
        public const string LOGPTN = "LOGPTN";

        /// <summary>
        /// LOATXN.
        /// </summary>
        public const string LOATXN = "LOATXN";

        /// <summary>
        /// LOTXR1.
        /// </summary>
        public const string LOTXR1 = "LOTXR1";

        /// <summary>
        /// LOAA15.
        /// </summary>
        public const string LOAA15 = "LOAA15";
    }

    /// <inheritdoc />
    public override string TableName => "F76VLO01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LODGJ", "LODGJ", JdeDataType.Numeric),
        new JdeField("LODCT", "LODCT", JdeDataType.String, 4, true, true),
        new JdeField("LODOC", "LODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("LOKCO", "LOKCO", JdeDataType.String, 10, true, true),
        new JdeField("LOFLAG", "LOFLAG", JdeDataType.String, 2),
        new JdeField("LOADID", "LOADID", JdeDataType.String, 4),
        new JdeField("LOTAX", "LOTAX", JdeDataType.String, 40),
        new JdeField("LOAGENT", "LOAGENT", JdeDataType.String, 40),
        new JdeField("LODC20", "LODC20", JdeDataType.String, 40),
        new JdeField("LODDES", "LODDES", JdeDataType.String, 40),
        new JdeField("LOAG", "LOAG", JdeDataType.Numeric),
        new JdeField("LOATXA", "LOATXA", JdeDataType.Numeric),
        new JdeField("LOSTAM", "LOSTAM", JdeDataType.Numeric),
        new JdeField("LOAAP", "LOAAP", JdeDataType.Numeric),
        new JdeField("LOALKY", "LOALKY", JdeDataType.String, 40),
        new JdeField("LOGPTN", "LOGPTN", JdeDataType.String, 28),
        new JdeField("LOATXN", "LOATXN", JdeDataType.Numeric),
        new JdeField("LOTXR1", "LOTXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("LOAA15", "LOAA15", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76VLO01_0", "Primary Key on LOKCO, LODCT, LODOC, LOTXR1", new[] { "LOKCO", "LODCT", "LODOC", "LOTXR1" }, isUnique: true, isPrimaryKey: true)
    };
}
