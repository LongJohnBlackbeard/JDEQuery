using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760101A - .
/// </summary>
public class F760101A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V0AN8.
        /// </summary>
        public const string V0AN8 = "V0AN8";

        /// <summary>
        /// V0ADCT.
        /// </summary>
        public const string V0ADCT = "V0ADCT";

        /// <summary>
        /// V0A001.
        /// </summary>
        public const string V0A001 = "V0A001";

        /// <summary>
        /// V0A002.
        /// </summary>
        public const string V0A002 = "V0A002";

        /// <summary>
        /// V0A003.
        /// </summary>
        public const string V0A003 = "V0A003";

        /// <summary>
        /// V0A004.
        /// </summary>
        public const string V0A004 = "V0A004";

        /// <summary>
        /// V0A005.
        /// </summary>
        public const string V0A005 = "V0A005";

        /// <summary>
        /// V0A006.
        /// </summary>
        public const string V0A006 = "V0A006";

        /// <summary>
        /// V0A007.
        /// </summary>
        public const string V0A007 = "V0A007";

        /// <summary>
        /// V0A008.
        /// </summary>
        public const string V0A008 = "V0A008";

        /// <summary>
        /// V0A009.
        /// </summary>
        public const string V0A009 = "V0A009";

        /// <summary>
        /// V0A010.
        /// </summary>
        public const string V0A010 = "V0A010";

        /// <summary>
        /// V0A011.
        /// </summary>
        public const string V0A011 = "V0A011";

        /// <summary>
        /// V0A012.
        /// </summary>
        public const string V0A012 = "V0A012";

        /// <summary>
        /// V0A013.
        /// </summary>
        public const string V0A013 = "V0A013";

        /// <summary>
        /// V0A014.
        /// </summary>
        public const string V0A014 = "V0A014";

        /// <summary>
        /// V0A015.
        /// </summary>
        public const string V0A015 = "V0A015";

        /// <summary>
        /// V0DSC2.
        /// </summary>
        public const string V0DSC2 = "V0DSC2";

        /// <summary>
        /// V0DSC3.
        /// </summary>
        public const string V0DSC3 = "V0DSC3";

        /// <summary>
        /// V0URAB.
        /// </summary>
        public const string V0URAB = "V0URAB";

        /// <summary>
        /// V0URDT.
        /// </summary>
        public const string V0URDT = "V0URDT";

        /// <summary>
        /// V0URC1.
        /// </summary>
        public const string V0URC1 = "V0URC1";

        /// <summary>
        /// V0URRF.
        /// </summary>
        public const string V0URRF = "V0URRF";
    }

    /// <inheritdoc />
    public override string TableName => "F760101A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V0AN8", "V0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("V0ADCT", "V0ADCT", JdeDataType.String, 6),
        new JdeField("V0A001", "V0A001", JdeDataType.String, 6),
        new JdeField("V0A002", "V0A002", JdeDataType.String, 6),
        new JdeField("V0A003", "V0A003", JdeDataType.String, 6),
        new JdeField("V0A004", "V0A004", JdeDataType.String, 6),
        new JdeField("V0A005", "V0A005", JdeDataType.String, 6),
        new JdeField("V0A006", "V0A006", JdeDataType.String, 6),
        new JdeField("V0A007", "V0A007", JdeDataType.String, 6),
        new JdeField("V0A008", "V0A008", JdeDataType.String, 6),
        new JdeField("V0A009", "V0A009", JdeDataType.String, 6),
        new JdeField("V0A010", "V0A010", JdeDataType.String, 6),
        new JdeField("V0A011", "V0A011", JdeDataType.String, 6),
        new JdeField("V0A012", "V0A012", JdeDataType.String, 6),
        new JdeField("V0A013", "V0A013", JdeDataType.String, 6),
        new JdeField("V0A014", "V0A014", JdeDataType.String, 6),
        new JdeField("V0A015", "V0A015", JdeDataType.String, 6),
        new JdeField("V0DSC2", "V0DSC2", JdeDataType.String, 60),
        new JdeField("V0DSC3", "V0DSC3", JdeDataType.String, 60),
        new JdeField("V0URAB", "V0URAB", JdeDataType.Numeric),
        new JdeField("V0URDT", "V0URDT", JdeDataType.Numeric),
        new JdeField("V0URC1", "V0URC1", JdeDataType.String, 6),
        new JdeField("V0URRF", "V0URRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760101A_0", "Primary Key on V0AN8", new[] { "V0AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
