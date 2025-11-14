using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F743012 - .
/// </summary>
public class F743012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEDOC.
        /// </summary>
        public const string PEDOC = "PEDOC";

        /// <summary>
        /// PEDCT.
        /// </summary>
        public const string PEDCT = "PEDCT";

        /// <summary>
        /// PEKCO.
        /// </summary>
        public const string PEKCO = "PEKCO";

        /// <summary>
        /// PEK74SED.
        /// </summary>
        public const string PEK74SED = "PEK74SED";

        /// <summary>
        /// PEK74USR.
        /// </summary>
        public const string PEK74USR = "PEK74USR";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PETORG.
        /// </summary>
        public const string PETORG = "PETORG";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PEUPMT.
        /// </summary>
        public const string PEUPMT = "PEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F743012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEDOC", "PEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PEDCT", "PEDCT", JdeDataType.String, 4, true, true),
        new JdeField("PEKCO", "PEKCO", JdeDataType.String, 10, true, true),
        new JdeField("PEK74SED", "PEK74SED", JdeDataType.Numeric),
        new JdeField("PEK74USR", "PEK74USR", JdeDataType.String, 4),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PETORG", "PETORG", JdeDataType.String, 20),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PEUPMT", "PEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F743012_0", "Primary Key on PEDOC, PEDCT, PEKCO", new[] { "PEDOC", "PEDCT", "PEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
