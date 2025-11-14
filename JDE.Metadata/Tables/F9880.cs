using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9880 - .
/// </summary>
public class F9880 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMENHV.
        /// </summary>
        public const string EMENHV = "EMENHV";

        /// <summary>
        /// EMMKEY.
        /// </summary>
        public const string EMMKEY = "EMMKEY";

        /// <summary>
        /// EMDL01.
        /// </summary>
        public const string EMDL01 = "EMDL01";

        /// <summary>
        /// EMJDESERV.
        /// </summary>
        public const string EMJDESERV = "EMJDESERV";

        /// <summary>
        /// EMJDESHRNM.
        /// </summary>
        public const string EMJDESHRNM = "EMJDESHRNM";

        /// <summary>
        /// EMJDESYDRC.
        /// </summary>
        public const string EMJDESYDRC = "EMJDESYDRC";

        /// <summary>
        /// EMJDEAPDRC.
        /// </summary>
        public const string EMJDEAPDRC = "EMJDEAPDRC";

        /// <summary>
        /// EMDATS.
        /// </summary>
        public const string EMDATS = "EMDATS";

        /// <summary>
        /// EMCHNG.
        /// </summary>
        public const string EMCHNG = "EMCHNG";

        /// <summary>
        /// EMJDEDBTYP.
        /// </summary>
        public const string EMJDEDBTYP = "EMJDEDBTYP";

        /// <summary>
        /// EMJDESERVM.
        /// </summary>
        public const string EMJDESERVM = "EMJDESERVM";
    }

    /// <inheritdoc />
    public override string TableName => "F9880";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMENHV", "EMENHV", JdeDataType.String, 20, true, true),
        new JdeField("EMMKEY", "EMMKEY", JdeDataType.String, 30, true, true),
        new JdeField("EMDL01", "EMDL01", JdeDataType.String, 60),
        new JdeField("EMJDESERV", "EMJDESERV", JdeDataType.String, 30),
        new JdeField("EMJDESHRNM", "EMJDESHRNM", JdeDataType.String, 30),
        new JdeField("EMJDESYDRC", "EMJDESYDRC", JdeDataType.String, 240),
        new JdeField("EMJDEAPDRC", "EMJDEAPDRC", JdeDataType.String, 240),
        new JdeField("EMDATS", "EMDATS", JdeDataType.String, 60),
        new JdeField("EMCHNG", "EMCHNG", JdeDataType.String, 2),
        new JdeField("EMJDEDBTYP", "EMJDEDBTYP", JdeDataType.String, 6),
        new JdeField("EMJDESERVM", "EMJDESERVM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9880_0", "Primary Key on EMENHV, EMMKEY", new[] { "EMENHV", "EMMKEY" }, isUnique: true, isPrimaryKey: true)
    };
}
