using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF160 - .
/// </summary>
public class F90CF160 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSCRPTID.
        /// </summary>
        public const string SCSCRPTID = "SCSCRPTID";

        /// <summary>
        /// SCTGSETID.
        /// </summary>
        public const string SCTGSETID = "SCTGSETID";

        /// <summary>
        /// SCSCRPTNM.
        /// </summary>
        public const string SCSCRPTNM = "SCSCRPTNM";

        /// <summary>
        /// SCSCRTYP.
        /// </summary>
        public const string SCSCRTYP = "SCSCRTYP";

        /// <summary>
        /// SCSCRDESC.
        /// </summary>
        public const string SCSCRDESC = "SCSCRDESC";

        /// <summary>
        /// SCSCRCTGRY.
        /// </summary>
        public const string SCSCRCTGRY = "SCSCRCTGRY";

        /// <summary>
        /// SCSCRSTAT.
        /// </summary>
        public const string SCSCRSTAT = "SCSCRSTAT";

        /// <summary>
        /// SCEFFDT.
        /// </summary>
        public const string SCEFFDT = "SCEFFDT";

        /// <summary>
        /// SCSCRWGHT.
        /// </summary>
        public const string SCSCRWGHT = "SCSCRWGHT";

        /// <summary>
        /// SCRTSTID.
        /// </summary>
        public const string SCRTSTID = "SCRTSTID";

        /// <summary>
        /// SCPREACTID.
        /// </summary>
        public const string SCPREACTID = "SCPREACTID";

        /// <summary>
        /// SCINCACTID.
        /// </summary>
        public const string SCINCACTID = "SCINCACTID";

        /// <summary>
        /// SCPSTACTID.
        /// </summary>
        public const string SCPSTACTID = "SCPSTACTID";

        /// <summary>
        /// SCEXTMSG.
        /// </summary>
        public const string SCEXTMSG = "SCEXTMSG";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCMKEY.
        /// </summary>
        public const string SCMKEY = "SCMKEY";

        /// <summary>
        /// SCUDTTM.
        /// </summary>
        public const string SCUDTTM = "SCUDTTM";

        /// <summary>
        /// SCSLTNVI.
        /// </summary>
        public const string SCSLTNVI = "SCSLTNVI";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSCRPTID", "SCSCRPTID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCTGSETID", "SCTGSETID", JdeDataType.String, 60),
        new JdeField("SCSCRPTNM", "SCSCRPTNM", JdeDataType.String, 80),
        new JdeField("SCSCRTYP", "SCSCRTYP", JdeDataType.String, 4),
        new JdeField("SCSCRDESC", "SCSCRDESC", JdeDataType.String, 508),
        new JdeField("SCSCRCTGRY", "SCSCRCTGRY", JdeDataType.String, 2),
        new JdeField("SCSCRSTAT", "SCSCRSTAT", JdeDataType.String, 2),
        new JdeField("SCEFFDT", "SCEFFDT", JdeDataType.Date),
        new JdeField("SCSCRWGHT", "SCSCRWGHT", JdeDataType.Numeric),
        new JdeField("SCRTSTID", "SCRTSTID", JdeDataType.Numeric),
        new JdeField("SCPREACTID", "SCPREACTID", JdeDataType.Numeric),
        new JdeField("SCINCACTID", "SCINCACTID", JdeDataType.Numeric),
        new JdeField("SCPSTACTID", "SCPSTACTID", JdeDataType.Numeric),
        new JdeField("SCEXTMSG", "SCEXTMSG", JdeDataType.String, 510),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCMKEY", "SCMKEY", JdeDataType.String, 30),
        new JdeField("SCUDTTM", "SCUDTTM", JdeDataType.Date),
        new JdeField("SCSLTNVI", "SCSLTNVI", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF160_0", "Primary Key on SCSCRPTID", new[] { "SCSCRPTID" }, isUnique: true, isPrimaryKey: true)
    };
}
