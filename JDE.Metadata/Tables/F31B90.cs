using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B90 - .
/// </summary>
public class F31B90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAWCFGID.
        /// </summary>
        public const string QAWCFGID = "QAWCFGID";

        /// <summary>
        /// QAQTST.
        /// </summary>
        public const string QAQTST = "QAQTST";

        /// <summary>
        /// QATSPL.
        /// </summary>
        public const string QATSPL = "QATSPL";

        /// <summary>
        /// QAURCD.
        /// </summary>
        public const string QAURCD = "QAURCD";

        /// <summary>
        /// QAURAT.
        /// </summary>
        public const string QAURAT = "QAURAT";

        /// <summary>
        /// QAURRF.
        /// </summary>
        public const string QAURRF = "QAURRF";

        /// <summary>
        /// QAURAB.
        /// </summary>
        public const string QAURAB = "QAURAB";

        /// <summary>
        /// QAURDT.
        /// </summary>
        public const string QAURDT = "QAURDT";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAUPMJ.
        /// </summary>
        public const string QAUPMJ = "QAUPMJ";

        /// <summary>
        /// QATDAY.
        /// </summary>
        public const string QATDAY = "QATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAWCFGID", "QAWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("QAQTST", "QAQTST", JdeDataType.String, 50, true, true),
        new JdeField("QATSPL", "QATSPL", JdeDataType.String, 2, true, true),
        new JdeField("QAURCD", "QAURCD", JdeDataType.String, 4),
        new JdeField("QAURAT", "QAURAT", JdeDataType.Numeric),
        new JdeField("QAURRF", "QAURRF", JdeDataType.String, 30),
        new JdeField("QAURAB", "QAURAB", JdeDataType.Numeric),
        new JdeField("QAURDT", "QAURDT", JdeDataType.Numeric),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QATDAY", "QATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B90_0", "Primary Key on QAWCFGID, QAQTST, QATSPL", new[] { "QAWCFGID", "QAQTST", "QATSPL" }, isUnique: true, isPrimaryKey: true)
    };
}
