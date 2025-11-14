using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B922 - .
/// </summary>
public class F31B922 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLPRMSNLST.
        /// </summary>
        public const string PLPRMSNLST = "PLPRMSNLST";

        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLWSD2.
        /// </summary>
        public const string PLWSD2 = "PLWSD2";

        /// <summary>
        /// PLWCFGID.
        /// </summary>
        public const string PLWCFGID = "PLWCFGID";

        /// <summary>
        /// PLWCOPCD.
        /// </summary>
        public const string PLWCOPCD = "PLWCOPCD";

        /// <summary>
        /// PLUACT.
        /// </summary>
        public const string PLUACT = "PLUACT";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLTDAY.
        /// </summary>
        public const string PLTDAY = "PLTDAY";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F31B922";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLPRMSNLST", "PLPRMSNLST", JdeDataType.String, 30, true, true),
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24, true, true),
        new JdeField("PLWSD2", "PLWSD2", JdeDataType.String, 60, true, true),
        new JdeField("PLWCFGID", "PLWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLWCOPCD", "PLWCOPCD", JdeDataType.String, 20),
        new JdeField("PLUACT", "PLUACT", JdeDataType.String, 2),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLTDAY", "PLTDAY", JdeDataType.Numeric),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B922_0", "Primary Key on PLPRMSNLST, PLMCU, PLWSD2, PLWCFGID", new[] { "PLPRMSNLST", "PLMCU", "PLWSD2", "PLWCFGID" }, isUnique: true, isPrimaryKey: true)
    };
}
