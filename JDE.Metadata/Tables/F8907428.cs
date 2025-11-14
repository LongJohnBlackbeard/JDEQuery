using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8907428 - .
/// </summary>
public class F8907428 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NEMATH01.
        /// </summary>
        public const string NEMATH01 = "NEMATH01";

        /// <summary>
        /// NETOU.
        /// </summary>
        public const string NETOU = "NETOU";

        /// <summary>
        /// NEFFU3.
        /// </summary>
        public const string NEFFU3 = "NEFFU3";

        /// <summary>
        /// NEDL01.
        /// </summary>
        public const string NEDL01 = "NEDL01";

        /// <summary>
        /// NETAXX.
        /// </summary>
        public const string NETAXX = "NETAXX";

        /// <summary>
        /// NEALPH.
        /// </summary>
        public const string NEALPH = "NEALPH";

        /// <summary>
        /// NEGNNM.
        /// </summary>
        public const string NEGNNM = "NEGNNM";

        /// <summary>
        /// NEMDNM.
        /// </summary>
        public const string NEMDNM = "NEMDNM";

        /// <summary>
        /// NESRNM.
        /// </summary>
        public const string NESRNM = "NESRNM";

        /// <summary>
        /// NEADD1.
        /// </summary>
        public const string NEADD1 = "NEADD1";

        /// <summary>
        /// NEADD2.
        /// </summary>
        public const string NEADD2 = "NEADD2";

        /// <summary>
        /// NEADD3.
        /// </summary>
        public const string NEADD3 = "NEADD3";

        /// <summary>
        /// NECTY1.
        /// </summary>
        public const string NECTY1 = "NECTY1";

        /// <summary>
        /// NEADDS.
        /// </summary>
        public const string NEADDS = "NEADDS";

        /// <summary>
        /// NEADDZ.
        /// </summary>
        public const string NEADDZ = "NEADDZ";

        /// <summary>
        /// NEALPH3.
        /// </summary>
        public const string NEALPH3 = "NEALPH3";

        /// <summary>
        /// NEPH1.
        /// </summary>
        public const string NEPH1 = "NEPH1";

        /// <summary>
        /// NEWKSE.
        /// </summary>
        public const string NEWKSE = "NEWKSE";
    }

    /// <inheritdoc />
    public override string TableName => "F8907428";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NEMATH01", "NEMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("NETOU", "NETOU", JdeDataType.Numeric),
        new JdeField("NEFFU3", "NEFFU3", JdeDataType.String, 20),
        new JdeField("NEDL01", "NEDL01", JdeDataType.String, 60),
        new JdeField("NETAXX", "NETAXX", JdeDataType.String, 40),
        new JdeField("NEALPH", "NEALPH", JdeDataType.String, 80),
        new JdeField("NEGNNM", "NEGNNM", JdeDataType.String, 50),
        new JdeField("NEMDNM", "NEMDNM", JdeDataType.String, 50),
        new JdeField("NESRNM", "NESRNM", JdeDataType.String, 50),
        new JdeField("NEADD1", "NEADD1", JdeDataType.String, 80),
        new JdeField("NEADD2", "NEADD2", JdeDataType.String, 80),
        new JdeField("NEADD3", "NEADD3", JdeDataType.String, 80),
        new JdeField("NECTY1", "NECTY1", JdeDataType.String, 50),
        new JdeField("NEADDS", "NEADDS", JdeDataType.String, 6),
        new JdeField("NEADDZ", "NEADDZ", JdeDataType.String, 24),
        new JdeField("NEALPH3", "NEALPH3", JdeDataType.String, 80),
        new JdeField("NEPH1", "NEPH1", JdeDataType.String, 40),
        new JdeField("NEWKSE", "NEWKSE", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8907428_0", "Primary Key on NEMATH01", new[] { "NEMATH01" }, isUnique: true, isPrimaryKey: true)
    };
}
