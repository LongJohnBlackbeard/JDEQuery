using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40721 - .
/// </summary>
public class F40721 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PVATID.
        /// </summary>
        public const string PVATID = "PVATID";

        /// <summary>
        /// PVAST.
        /// </summary>
        public const string PVAST = "PVAST";

        /// <summary>
        /// PVRCTY.
        /// </summary>
        public const string PVRCTY = "PVRCTY";

        /// <summary>
        /// PVSEQ.
        /// </summary>
        public const string PVSEQ = "PVSEQ";

        /// <summary>
        /// PVDTAI.
        /// </summary>
        public const string PVDTAI = "PVDTAI";

        /// <summary>
        /// PVSQPR.
        /// </summary>
        public const string PVSQPR = "PVSQPR";

        /// <summary>
        /// PVGENMATH.
        /// </summary>
        public const string PVGENMATH = "PVGENMATH";

        /// <summary>
        /// PVGENSTR.
        /// </summary>
        public const string PVGENSTR = "PVGENSTR";

        /// <summary>
        /// PVGENCHAR.
        /// </summary>
        public const string PVGENCHAR = "PVGENCHAR";

        /// <summary>
        /// PVGENDATE.
        /// </summary>
        public const string PVGENDATE = "PVGENDATE";

        /// <summary>
        /// PVUSER.
        /// </summary>
        public const string PVUSER = "PVUSER";

        /// <summary>
        /// PVPID.
        /// </summary>
        public const string PVPID = "PVPID";

        /// <summary>
        /// PVJOBN.
        /// </summary>
        public const string PVJOBN = "PVJOBN";

        /// <summary>
        /// PVUPMJ.
        /// </summary>
        public const string PVUPMJ = "PVUPMJ";

        /// <summary>
        /// PVTDAY.
        /// </summary>
        public const string PVTDAY = "PVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40721";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PVATID", "PVATID", JdeDataType.Numeric, null, true, true),
        new JdeField("PVAST", "PVAST", JdeDataType.String, 16, true, true),
        new JdeField("PVRCTY", "PVRCTY", JdeDataType.String, 2, true, true),
        new JdeField("PVSEQ", "PVSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PVDTAI", "PVDTAI", JdeDataType.String, 20, true, true),
        new JdeField("PVSQPR", "PVSQPR", JdeDataType.Numeric, null, true, true),
        new JdeField("PVGENMATH", "PVGENMATH", JdeDataType.Numeric),
        new JdeField("PVGENSTR", "PVGENSTR", JdeDataType.String, 60),
        new JdeField("PVGENCHAR", "PVGENCHAR", JdeDataType.String, 2),
        new JdeField("PVGENDATE", "PVGENDATE", JdeDataType.Numeric),
        new JdeField("PVUSER", "PVUSER", JdeDataType.String, 20),
        new JdeField("PVPID", "PVPID", JdeDataType.String, 20),
        new JdeField("PVJOBN", "PVJOBN", JdeDataType.String, 20),
        new JdeField("PVUPMJ", "PVUPMJ", JdeDataType.Numeric),
        new JdeField("PVTDAY", "PVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40721_0", "Primary Key on PVATID, PVAST, PVRCTY, PVSEQ, PVDTAI, PVSQPR", new[] { "PVATID", "PVAST", "PVRCTY", "PVSEQ", "PVDTAI", "PVSQPR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40721_2", "Index on PVATID, PVAST, PVSEQ, PVRCTY, PVDTAI", new[] { "PVATID", "PVAST", "PVSEQ", "PVRCTY", "PVDTAI" })
    };
}
