using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4101G - .
/// </summary>
public class F4101G : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBMCU.
        /// </summary>
        public const string IBMCU = "IBMCU";

        /// <summary>
        /// IBITM.
        /// </summary>
        public const string IBITM = "IBITM";

        /// <summary>
        /// IBSTAW.
        /// </summary>
        public const string IBSTAW = "IBSTAW";

        /// <summary>
        /// IBEFFT.
        /// </summary>
        public const string IBEFFT = "IBEFFT";

        /// <summary>
        /// IBDOC.
        /// </summary>
        public const string IBDOC = "IBDOC";

        /// <summary>
        /// IBDCT.
        /// </summary>
        public const string IBDCT = "IBDCT";

        /// <summary>
        /// IBEFFF.
        /// </summary>
        public const string IBEFFF = "IBEFFF";

        /// <summary>
        /// IBSERK.
        /// </summary>
        public const string IBSERK = "IBSERK";

        /// <summary>
        /// IBROPI.
        /// </summary>
        public const string IBROPI = "IBROPI";

        /// <summary>
        /// IBROQI.
        /// </summary>
        public const string IBROQI = "IBROQI";

        /// <summary>
        /// IBRQMX.
        /// </summary>
        public const string IBRQMX = "IBRQMX";

        /// <summary>
        /// IBRQMN.
        /// </summary>
        public const string IBRQMN = "IBRQMN";

        /// <summary>
        /// IBSAFE.
        /// </summary>
        public const string IBSAFE = "IBSAFE";

        /// <summary>
        /// IBUPC.
        /// </summary>
        public const string IBUPC = "IBUPC";

        /// <summary>
        /// IBMULT.
        /// </summary>
        public const string IBMULT = "IBMULT";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBTDAY.
        /// </summary>
        public const string IBTDAY = "IBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4101G";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBMCU", "IBMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBITM", "IBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBSTAW", "IBSTAW", JdeDataType.String, 2, true, true),
        new JdeField("IBEFFT", "IBEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("IBDOC", "IBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IBDCT", "IBDCT", JdeDataType.String, 4, true, true),
        new JdeField("IBEFFF", "IBEFFF", JdeDataType.Numeric),
        new JdeField("IBSERK", "IBSERK", JdeDataType.Numeric),
        new JdeField("IBROPI", "IBROPI", JdeDataType.Numeric),
        new JdeField("IBROQI", "IBROQI", JdeDataType.Numeric),
        new JdeField("IBRQMX", "IBRQMX", JdeDataType.Numeric),
        new JdeField("IBRQMN", "IBRQMN", JdeDataType.Numeric),
        new JdeField("IBSAFE", "IBSAFE", JdeDataType.Numeric),
        new JdeField("IBUPC", "IBUPC", JdeDataType.Numeric),
        new JdeField("IBMULT", "IBMULT", JdeDataType.Numeric),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBTDAY", "IBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4101G_0", "Primary Key on IBMCU, IBITM, IBSTAW, IBEFFT, IBDOC, IBDCT", new[] { "IBMCU", "IBITM", "IBSTAW", "IBEFFT", "IBDOC", "IBDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
