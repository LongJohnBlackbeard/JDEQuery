using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A010Z - .
/// </summary>
public class F76A010Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V9EDUS.
        /// </summary>
        public const string V9EDUS = "V9EDUS";

        /// <summary>
        /// V9EDBT.
        /// </summary>
        public const string V9EDBT = "V9EDBT";

        /// <summary>
        /// V9EDTN.
        /// </summary>
        public const string V9EDTN = "V9EDTN";

        /// <summary>
        /// V9EDLN.
        /// </summary>
        public const string V9EDLN = "V9EDLN";

        /// <summary>
        /// V9ADCT.
        /// </summary>
        public const string V9ADCT = "V9ADCT";

        /// <summary>
        /// V9A001.
        /// </summary>
        public const string V9A001 = "V9A001";

        /// <summary>
        /// V9A002.
        /// </summary>
        public const string V9A002 = "V9A002";

        /// <summary>
        /// V9A003.
        /// </summary>
        public const string V9A003 = "V9A003";

        /// <summary>
        /// V9A004.
        /// </summary>
        public const string V9A004 = "V9A004";

        /// <summary>
        /// V9A005.
        /// </summary>
        public const string V9A005 = "V9A005";

        /// <summary>
        /// V9A006.
        /// </summary>
        public const string V9A006 = "V9A006";

        /// <summary>
        /// V9A007.
        /// </summary>
        public const string V9A007 = "V9A007";

        /// <summary>
        /// V9A008.
        /// </summary>
        public const string V9A008 = "V9A008";

        /// <summary>
        /// V9A009.
        /// </summary>
        public const string V9A009 = "V9A009";

        /// <summary>
        /// V9A010.
        /// </summary>
        public const string V9A010 = "V9A010";

        /// <summary>
        /// V9A011.
        /// </summary>
        public const string V9A011 = "V9A011";

        /// <summary>
        /// V9A012.
        /// </summary>
        public const string V9A012 = "V9A012";

        /// <summary>
        /// V9A013.
        /// </summary>
        public const string V9A013 = "V9A013";

        /// <summary>
        /// V9A014.
        /// </summary>
        public const string V9A014 = "V9A014";

        /// <summary>
        /// V9A015.
        /// </summary>
        public const string V9A015 = "V9A015";

        /// <summary>
        /// V9DSC2.
        /// </summary>
        public const string V9DSC2 = "V9DSC2";

        /// <summary>
        /// V9DSC3.
        /// </summary>
        public const string V9DSC3 = "V9DSC3";

        /// <summary>
        /// V9URAB.
        /// </summary>
        public const string V9URAB = "V9URAB";

        /// <summary>
        /// V9URDT.
        /// </summary>
        public const string V9URDT = "V9URDT";

        /// <summary>
        /// V9URC1.
        /// </summary>
        public const string V9URC1 = "V9URC1";

        /// <summary>
        /// V9URRF.
        /// </summary>
        public const string V9URRF = "V9URRF";
    }

    /// <inheritdoc />
    public override string TableName => "F76A010Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V9EDUS", "V9EDUS", JdeDataType.String, 20, true, true),
        new JdeField("V9EDBT", "V9EDBT", JdeDataType.String, 30, true, true),
        new JdeField("V9EDTN", "V9EDTN", JdeDataType.String, 44, true, true),
        new JdeField("V9EDLN", "V9EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("V9ADCT", "V9ADCT", JdeDataType.String, 6),
        new JdeField("V9A001", "V9A001", JdeDataType.String, 6),
        new JdeField("V9A002", "V9A002", JdeDataType.String, 6),
        new JdeField("V9A003", "V9A003", JdeDataType.String, 6),
        new JdeField("V9A004", "V9A004", JdeDataType.String, 6),
        new JdeField("V9A005", "V9A005", JdeDataType.String, 6),
        new JdeField("V9A006", "V9A006", JdeDataType.String, 6),
        new JdeField("V9A007", "V9A007", JdeDataType.String, 6),
        new JdeField("V9A008", "V9A008", JdeDataType.String, 6),
        new JdeField("V9A009", "V9A009", JdeDataType.String, 6),
        new JdeField("V9A010", "V9A010", JdeDataType.String, 6),
        new JdeField("V9A011", "V9A011", JdeDataType.String, 6),
        new JdeField("V9A012", "V9A012", JdeDataType.String, 6),
        new JdeField("V9A013", "V9A013", JdeDataType.String, 6),
        new JdeField("V9A014", "V9A014", JdeDataType.String, 6),
        new JdeField("V9A015", "V9A015", JdeDataType.String, 6),
        new JdeField("V9DSC2", "V9DSC2", JdeDataType.String, 60),
        new JdeField("V9DSC3", "V9DSC3", JdeDataType.String, 60),
        new JdeField("V9URAB", "V9URAB", JdeDataType.Numeric),
        new JdeField("V9URDT", "V9URDT", JdeDataType.Numeric),
        new JdeField("V9URC1", "V9URC1", JdeDataType.String, 6),
        new JdeField("V9URRF", "V9URRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A010Z_0", "Primary Key on V9EDUS, V9EDBT, V9EDTN, V9EDLN", new[] { "V9EDUS", "V9EDBT", "V9EDTN", "V9EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
