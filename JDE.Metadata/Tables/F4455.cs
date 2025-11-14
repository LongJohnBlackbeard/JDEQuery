using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4455 - .
/// </summary>
public class F4455 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHMCU.
        /// </summary>
        public const string JHMCU = "JHMCU";

        /// <summary>
        /// JHALOT.
        /// </summary>
        public const string JHALOT = "JHALOT";

        /// <summary>
        /// JHOPTN.
        /// </summary>
        public const string JHOPTN = "JHOPTN";

        /// <summary>
        /// JHR001.
        /// </summary>
        public const string JHR001 = "JHR001";

        /// <summary>
        /// JHCTYC.
        /// </summary>
        public const string JHCTYC = "JHCTYC";

        /// <summary>
        /// JHDOCO.
        /// </summary>
        public const string JHDOCO = "JHDOCO";

        /// <summary>
        /// JHDCTO.
        /// </summary>
        public const string JHDCTO = "JHDCTO";

        /// <summary>
        /// JHAN8.
        /// </summary>
        public const string JHAN8 = "JHAN8";

        /// <summary>
        /// JHTRDJ.
        /// </summary>
        public const string JHTRDJ = "JHTRDJ";

        /// <summary>
        /// JHUPMJ.
        /// </summary>
        public const string JHUPMJ = "JHUPMJ";

        /// <summary>
        /// JHPID.
        /// </summary>
        public const string JHPID = "JHPID";

        /// <summary>
        /// JHUSER.
        /// </summary>
        public const string JHUSER = "JHUSER";

        /// <summary>
        /// JHJOBN.
        /// </summary>
        public const string JHJOBN = "JHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4455";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHMCU", "JHMCU", JdeDataType.String, 24, true, true),
        new JdeField("JHALOT", "JHALOT", JdeDataType.String, 8, true, true),
        new JdeField("JHOPTN", "JHOPTN", JdeDataType.String, 16, true, true),
        new JdeField("JHR001", "JHR001", JdeDataType.String, 6, true, true),
        new JdeField("JHCTYC", "JHCTYC", JdeDataType.String, 6, true, true),
        new JdeField("JHDOCO", "JHDOCO", JdeDataType.Numeric),
        new JdeField("JHDCTO", "JHDCTO", JdeDataType.String, 4),
        new JdeField("JHAN8", "JHAN8", JdeDataType.Numeric),
        new JdeField("JHTRDJ", "JHTRDJ", JdeDataType.Numeric),
        new JdeField("JHUPMJ", "JHUPMJ", JdeDataType.Numeric),
        new JdeField("JHPID", "JHPID", JdeDataType.String, 20),
        new JdeField("JHUSER", "JHUSER", JdeDataType.String, 20),
        new JdeField("JHJOBN", "JHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4455_0", "Primary Key on JHR001, JHCTYC, JHMCU, JHALOT, JHOPTN", new[] { "JHR001", "JHCTYC", "JHMCU", "JHALOT", "JHOPTN" }, isUnique: true, isPrimaryKey: true)
    };
}
