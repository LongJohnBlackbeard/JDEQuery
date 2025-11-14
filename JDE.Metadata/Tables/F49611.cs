using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49611 - .
/// </summary>
public class F49611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDVMCU.
        /// </summary>
        public const string LDVMCU = "LDVMCU";

        /// <summary>
        /// LDLDNM.
        /// </summary>
        public const string LDLDNM = "LDLDNM";

        /// <summary>
        /// LDSTSQ.
        /// </summary>
        public const string LDSTSQ = "LDSTSQ";

        /// <summary>
        /// LDTRPL.
        /// </summary>
        public const string LDTRPL = "LDTRPL";

        /// <summary>
        /// LDANCC.
        /// </summary>
        public const string LDANCC = "LDANCC";

        /// <summary>
        /// LDMCUX.
        /// </summary>
        public const string LDMCUX = "LDMCUX";

        /// <summary>
        /// LDSPTY.
        /// </summary>
        public const string LDSPTY = "LDSPTY";

        /// <summary>
        /// LDRSDJ.
        /// </summary>
        public const string LDRSDJ = "LDRSDJ";

        /// <summary>
        /// LDRSDT.
        /// </summary>
        public const string LDRSDT = "LDRSDT";

        /// <summary>
        /// LDDSTN.
        /// </summary>
        public const string LDDSTN = "LDDSTN";

        /// <summary>
        /// LDUMD1.
        /// </summary>
        public const string LDUMD1 = "LDUMD1";

        /// <summary>
        /// LDDSRC.
        /// </summary>
        public const string LDDSRC = "LDDSRC";

        /// <summary>
        /// LDURCD.
        /// </summary>
        public const string LDURCD = "LDURCD";

        /// <summary>
        /// LDURDT.
        /// </summary>
        public const string LDURDT = "LDURDT";

        /// <summary>
        /// LDURAT.
        /// </summary>
        public const string LDURAT = "LDURAT";

        /// <summary>
        /// LDURAB.
        /// </summary>
        public const string LDURAB = "LDURAB";

        /// <summary>
        /// LDURRF.
        /// </summary>
        public const string LDURRF = "LDURRF";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDTDAY.
        /// </summary>
        public const string LDTDAY = "LDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDVMCU", "LDVMCU", JdeDataType.String, 24, true, true),
        new JdeField("LDLDNM", "LDLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("LDSTSQ", "LDSTSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LDTRPL", "LDTRPL", JdeDataType.Numeric),
        new JdeField("LDANCC", "LDANCC", JdeDataType.Numeric),
        new JdeField("LDMCUX", "LDMCUX", JdeDataType.String, 24),
        new JdeField("LDSPTY", "LDSPTY", JdeDataType.String, 6),
        new JdeField("LDRSDJ", "LDRSDJ", JdeDataType.Numeric),
        new JdeField("LDRSDT", "LDRSDT", JdeDataType.Numeric),
        new JdeField("LDDSTN", "LDDSTN", JdeDataType.Numeric),
        new JdeField("LDUMD1", "LDUMD1", JdeDataType.String, 4),
        new JdeField("LDDSRC", "LDDSRC", JdeDataType.String, 2),
        new JdeField("LDURCD", "LDURCD", JdeDataType.String, 4),
        new JdeField("LDURDT", "LDURDT", JdeDataType.Numeric),
        new JdeField("LDURAT", "LDURAT", JdeDataType.Numeric),
        new JdeField("LDURAB", "LDURAB", JdeDataType.Numeric),
        new JdeField("LDURRF", "LDURRF", JdeDataType.String, 30),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDTDAY", "LDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49611_0", "Primary Key on LDVMCU, LDLDNM, LDSTSQ", new[] { "LDVMCU", "LDLDNM", "LDSTSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
