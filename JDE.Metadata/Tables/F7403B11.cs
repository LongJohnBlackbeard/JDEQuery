using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7403B11 - .
/// </summary>
public class F7403B11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAAN8.
        /// </summary>
        public const string QAAN8 = "QAAN8";

        /// <summary>
        /// QANAME.
        /// </summary>
        public const string QANAME = "QANAME";

        /// <summary>
        /// QAADD1.
        /// </summary>
        public const string QAADD1 = "QAADD1";

        /// <summary>
        /// QAADDZ.
        /// </summary>
        public const string QAADDZ = "QAADDZ";

        /// <summary>
        /// QACTY1.
        /// </summary>
        public const string QACTY1 = "QACTY1";

        /// <summary>
        /// QAEV01.
        /// </summary>
        public const string QAEV01 = "QAEV01";

        /// <summary>
        /// QATAX.
        /// </summary>
        public const string QATAX = "QATAX";

        /// <summary>
        /// QASTAM.
        /// </summary>
        public const string QASTAM = "QASTAM";

        /// <summary>
        /// QAATXA.
        /// </summary>
        public const string QAATXA = "QAATXA";

        /// <summary>
        /// QATX1.
        /// </summary>
        public const string QATX1 = "QATX1";

        /// <summary>
        /// QAUKID.
        /// </summary>
        public const string QAUKID = "QAUKID";

        /// <summary>
        /// QASORT.
        /// </summary>
        public const string QASORT = "QASORT";
    }

    /// <inheritdoc />
    public override string TableName => "F7403B11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAAN8", "QAAN8", JdeDataType.Numeric),
        new JdeField("QANAME", "QANAME", JdeDataType.String, 60),
        new JdeField("QAADD1", "QAADD1", JdeDataType.String, 80),
        new JdeField("QAADDZ", "QAADDZ", JdeDataType.String, 24),
        new JdeField("QACTY1", "QACTY1", JdeDataType.String, 50),
        new JdeField("QAEV01", "QAEV01", JdeDataType.String, 2),
        new JdeField("QATAX", "QATAX", JdeDataType.String, 40),
        new JdeField("QASTAM", "QASTAM", JdeDataType.Numeric),
        new JdeField("QAATXA", "QAATXA", JdeDataType.Numeric),
        new JdeField("QATX1", "QATX1", JdeDataType.String, 32, true, true),
        new JdeField("QAUKID", "QAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("QASORT", "QASORT", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7403B11_0", "Primary Key on QATX1, QAUKID", new[] { "QATX1", "QAUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
