using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF040 - .
/// </summary>
public class F90CF040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASANSETID.
        /// </summary>
        public const string ASANSETID = "ASANSETID";

        /// <summary>
        /// ASANSSTNM.
        /// </summary>
        public const string ASANSSTNM = "ASANSSTNM";

        /// <summary>
        /// ASANSETTYP.
        /// </summary>
        public const string ASANSETTYP = "ASANSETTYP";

        /// <summary>
        /// ASANSETSTS.
        /// </summary>
        public const string ASANSETSTS = "ASANSETSTS";

        /// <summary>
        /// ASRULSTID.
        /// </summary>
        public const string ASRULSTID = "ASRULSTID";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASJOBN.
        /// </summary>
        public const string ASJOBN = "ASJOBN";

        /// <summary>
        /// ASMKEY.
        /// </summary>
        public const string ASMKEY = "ASMKEY";

        /// <summary>
        /// ASUDTTM.
        /// </summary>
        public const string ASUDTTM = "ASUDTTM";

        /// <summary>
        /// ASANSTDESC.
        /// </summary>
        public const string ASANSTDESC = "ASANSTDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASANSETID", "ASANSETID", JdeDataType.Numeric, null, true, true),
        new JdeField("ASANSSTNM", "ASANSSTNM", JdeDataType.String, 80),
        new JdeField("ASANSETTYP", "ASANSETTYP", JdeDataType.String, 2),
        new JdeField("ASANSETSTS", "ASANSETSTS", JdeDataType.String, 2),
        new JdeField("ASRULSTID", "ASRULSTID", JdeDataType.Numeric),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASJOBN", "ASJOBN", JdeDataType.String, 20),
        new JdeField("ASMKEY", "ASMKEY", JdeDataType.String, 30),
        new JdeField("ASUDTTM", "ASUDTTM", JdeDataType.Date),
        new JdeField("ASANSTDESC", "ASANSTDESC", JdeDataType.String, 508)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF040_0", "Primary Key on ASANSETID", new[] { "ASANSETID" }, isUnique: true, isPrimaryKey: true)
    };
}
