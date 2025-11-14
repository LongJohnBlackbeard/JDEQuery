using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08500 - .
/// </summary>
public class F08500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESDIVC.
        /// </summary>
        public const string ESDIVC = "ESDIVC";

        /// <summary>
        /// ESEECD.
        /// </summary>
        public const string ESEECD = "ESEECD";

        /// <summary>
        /// ESEFT.
        /// </summary>
        public const string ESEFT = "ESEFT";

        /// <summary>
        /// ESEFTE.
        /// </summary>
        public const string ESEFTE = "ESEFTE";

        /// <summary>
        /// ESDTAI.
        /// </summary>
        public const string ESDTAI = "ESDTAI";

        /// <summary>
        /// ESCDEL.
        /// </summary>
        public const string ESCDEL = "ESCDEL";

        /// <summary>
        /// ESERED.
        /// </summary>
        public const string ESERED = "ESERED";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESUPMJ.
        /// </summary>
        public const string ESUPMJ = "ESUPMJ";

        /// <summary>
        /// ESTME0.
        /// </summary>
        public const string ESTME0 = "ESTME0";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESJOBN.
        /// </summary>
        public const string ESJOBN = "ESJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESDIVC", "ESDIVC", JdeDataType.String, 12, true, true),
        new JdeField("ESEECD", "ESEECD", JdeDataType.String, 6, true, true),
        new JdeField("ESEFT", "ESEFT", JdeDataType.Numeric),
        new JdeField("ESEFTE", "ESEFTE", JdeDataType.Numeric),
        new JdeField("ESDTAI", "ESDTAI", JdeDataType.String, 20),
        new JdeField("ESCDEL", "ESCDEL", JdeDataType.Numeric),
        new JdeField("ESERED", "ESERED", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESUPMJ", "ESUPMJ", JdeDataType.Numeric),
        new JdeField("ESTME0", "ESTME0", JdeDataType.Numeric),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESJOBN", "ESJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08500_0", "Primary Key on ESDIVC, ESEECD", new[] { "ESDIVC", "ESEECD" }, isUnique: true, isPrimaryKey: true)
    };
}
