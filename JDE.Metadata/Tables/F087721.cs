using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087721 - .
/// </summary>
public class F087721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XPJOBS.
        /// </summary>
        public const string XPJOBS = "XPJOBS";

        /// <summary>
        /// XPANPA.
        /// </summary>
        public const string XPANPA = "XPANPA";

        /// <summary>
        /// XPAN8.
        /// </summary>
        public const string XPAN8 = "XPAN8";

        /// <summary>
        /// XPTINC.
        /// </summary>
        public const string XPTINC = "XPTINC";

        /// <summary>
        /// XPDEF.
        /// </summary>
        public const string XPDEF = "XPDEF";

        /// <summary>
        /// XPGAPS.
        /// </summary>
        public const string XPGAPS = "XPGAPS";

        /// <summary>
        /// XPFRVW.
        /// </summary>
        public const string XPFRVW = "XPFRVW";

        /// <summary>
        /// XPTRVW.
        /// </summary>
        public const string XPTRVW = "XPTRVW";

        /// <summary>
        /// XPPADD.
        /// </summary>
        public const string XPPADD = "XPPADD";

        /// <summary>
        /// XPESADD.
        /// </summary>
        public const string XPESADD = "XPESADD";

        /// <summary>
        /// XPDIRIN.
        /// </summary>
        public const string XPDIRIN = "XPDIRIN";

        /// <summary>
        /// XPSERK.
        /// </summary>
        public const string XPSERK = "XPSERK";
    }

    /// <inheritdoc />
    public override string TableName => "F087721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XPJOBS", "XPJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("XPANPA", "XPANPA", JdeDataType.Numeric, null, true, true),
        new JdeField("XPAN8", "XPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XPTINC", "XPTINC", JdeDataType.String, 2),
        new JdeField("XPDEF", "XPDEF", JdeDataType.Numeric),
        new JdeField("XPGAPS", "XPGAPS", JdeDataType.String, 6),
        new JdeField("XPFRVW", "XPFRVW", JdeDataType.Numeric),
        new JdeField("XPTRVW", "XPTRVW", JdeDataType.Numeric),
        new JdeField("XPPADD", "XPPADD", JdeDataType.Numeric),
        new JdeField("XPESADD", "XPESADD", JdeDataType.Numeric),
        new JdeField("XPDIRIN", "XPDIRIN", JdeDataType.String, 2),
        new JdeField("XPSERK", "XPSERK", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087721_0", "Primary Key on XPJOBS, XPANPA, XPAN8", new[] { "XPJOBS", "XPANPA", "XPAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
