using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A30 - .
/// </summary>
public class F76A30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V8EDUS.
        /// </summary>
        public const string V8EDUS = "V8EDUS";

        /// <summary>
        /// V8EDBT.
        /// </summary>
        public const string V8EDBT = "V8EDBT";

        /// <summary>
        /// V8EDTN.
        /// </summary>
        public const string V8EDTN = "V8EDTN";

        /// <summary>
        /// V8EDLN.
        /// </summary>
        public const string V8EDLN = "V8EDLN";

        /// <summary>
        /// V8AINC.
        /// </summary>
        public const string V8AINC = "V8AINC";

        /// <summary>
        /// V8AADJ.
        /// </summary>
        public const string V8AADJ = "V8AADJ";

        /// <summary>
        /// V8AADN.
        /// </summary>
        public const string V8AADN = "V8AADN";

        /// <summary>
        /// V8ADGI.
        /// </summary>
        public const string V8ADGI = "V8ADGI";

        /// <summary>
        /// V8APFC.
        /// </summary>
        public const string V8APFC = "V8APFC";

        /// <summary>
        /// V8ARED.
        /// </summary>
        public const string V8ARED = "V8ARED";

        /// <summary>
        /// V8A001.
        /// </summary>
        public const string V8A001 = "V8A001";

        /// <summary>
        /// V8A002.
        /// </summary>
        public const string V8A002 = "V8A002";

        /// <summary>
        /// V8A003.
        /// </summary>
        public const string V8A003 = "V8A003";

        /// <summary>
        /// V8A004.
        /// </summary>
        public const string V8A004 = "V8A004";

        /// <summary>
        /// V8A005.
        /// </summary>
        public const string V8A005 = "V8A005";

        /// <summary>
        /// V8A006.
        /// </summary>
        public const string V8A006 = "V8A006";

        /// <summary>
        /// V8A007.
        /// </summary>
        public const string V8A007 = "V8A007";

        /// <summary>
        /// V8A008.
        /// </summary>
        public const string V8A008 = "V8A008";

        /// <summary>
        /// V8A009.
        /// </summary>
        public const string V8A009 = "V8A009";

        /// <summary>
        /// V8A010.
        /// </summary>
        public const string V8A010 = "V8A010";

        /// <summary>
        /// V8A011.
        /// </summary>
        public const string V8A011 = "V8A011";

        /// <summary>
        /// V8A012.
        /// </summary>
        public const string V8A012 = "V8A012";

        /// <summary>
        /// V8A013.
        /// </summary>
        public const string V8A013 = "V8A013";

        /// <summary>
        /// V8A014.
        /// </summary>
        public const string V8A014 = "V8A014";

        /// <summary>
        /// V8A015.
        /// </summary>
        public const string V8A015 = "V8A015";

        /// <summary>
        /// V8URAB.
        /// </summary>
        public const string V8URAB = "V8URAB";

        /// <summary>
        /// V8URAT.
        /// </summary>
        public const string V8URAT = "V8URAT";

        /// <summary>
        /// V8URDT.
        /// </summary>
        public const string V8URDT = "V8URDT";

        /// <summary>
        /// V8URC1.
        /// </summary>
        public const string V8URC1 = "V8URC1";

        /// <summary>
        /// V8URRF.
        /// </summary>
        public const string V8URRF = "V8URRF";

        /// <summary>
        /// V8AGRP.
        /// </summary>
        public const string V8AGRP = "V8AGRP";

        /// <summary>
        /// V8AOP.
        /// </summary>
        public const string V8AOP = "V8AOP";

        /// <summary>
        /// V8ADGI1.
        /// </summary>
        public const string V8ADGI1 = "V8ADGI1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V8EDUS", "V8EDUS", JdeDataType.String, 20, true, true),
        new JdeField("V8EDBT", "V8EDBT", JdeDataType.String, 30, true, true),
        new JdeField("V8EDTN", "V8EDTN", JdeDataType.String, 44, true, true),
        new JdeField("V8EDLN", "V8EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("V8AINC", "V8AINC", JdeDataType.String, 2),
        new JdeField("V8AADJ", "V8AADJ", JdeDataType.Numeric),
        new JdeField("V8AADN", "V8AADN", JdeDataType.String, 16),
        new JdeField("V8ADGI", "V8ADGI", JdeDataType.String, 4),
        new JdeField("V8APFC", "V8APFC", JdeDataType.Numeric),
        new JdeField("V8ARED", "V8ARED", JdeDataType.String, 2),
        new JdeField("V8A001", "V8A001", JdeDataType.String, 6),
        new JdeField("V8A002", "V8A002", JdeDataType.String, 6),
        new JdeField("V8A003", "V8A003", JdeDataType.String, 6),
        new JdeField("V8A004", "V8A004", JdeDataType.String, 6),
        new JdeField("V8A005", "V8A005", JdeDataType.String, 6),
        new JdeField("V8A006", "V8A006", JdeDataType.String, 6),
        new JdeField("V8A007", "V8A007", JdeDataType.String, 6),
        new JdeField("V8A008", "V8A008", JdeDataType.String, 6),
        new JdeField("V8A009", "V8A009", JdeDataType.String, 6),
        new JdeField("V8A010", "V8A010", JdeDataType.String, 6),
        new JdeField("V8A011", "V8A011", JdeDataType.String, 6),
        new JdeField("V8A012", "V8A012", JdeDataType.String, 6),
        new JdeField("V8A013", "V8A013", JdeDataType.String, 6),
        new JdeField("V8A014", "V8A014", JdeDataType.String, 6),
        new JdeField("V8A015", "V8A015", JdeDataType.String, 6),
        new JdeField("V8URAB", "V8URAB", JdeDataType.Numeric),
        new JdeField("V8URAT", "V8URAT", JdeDataType.Numeric),
        new JdeField("V8URDT", "V8URDT", JdeDataType.Numeric),
        new JdeField("V8URC1", "V8URC1", JdeDataType.String, 6),
        new JdeField("V8URRF", "V8URRF", JdeDataType.String, 30),
        new JdeField("V8AGRP", "V8AGRP", JdeDataType.String, 2),
        new JdeField("V8AOP", "V8AOP", JdeDataType.Numeric),
        new JdeField("V8ADGI1", "V8ADGI1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A30_0", "Primary Key on V8EDUS, V8EDBT, V8EDTN, V8EDLN", new[] { "V8EDUS", "V8EDBT", "V8EDTN", "V8EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
