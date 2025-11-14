using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE02 - .
/// </summary>
public class F90CE02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LILIBID.
        /// </summary>
        public const string LILIBID = "LILIBID";

        /// <summary>
        /// LILIBNAME.
        /// </summary>
        public const string LILIBNAME = "LILIBNAME";

        /// <summary>
        /// LILIBDESC.
        /// </summary>
        public const string LILIBDESC = "LILIBDESC";

        /// <summary>
        /// LISETID.
        /// </summary>
        public const string LISETID = "LISETID";

        /// <summary>
        /// LIDFLTFLG.
        /// </summary>
        public const string LIDFLTFLG = "LIDFLTFLG";

        /// <summary>
        /// LISEARCHBL.
        /// </summary>
        public const string LISEARCHBL = "LISEARCHBL";

        /// <summary>
        /// LIENTDBY.
        /// </summary>
        public const string LIENTDBY = "LIENTDBY";

        /// <summary>
        /// LIEDATE.
        /// </summary>
        public const string LIEDATE = "LIEDATE";

        /// <summary>
        /// LIUSER.
        /// </summary>
        public const string LIUSER = "LIUSER";

        /// <summary>
        /// LIUDTTM.
        /// </summary>
        public const string LIUDTTM = "LIUDTTM";

        /// <summary>
        /// LIMKEY.
        /// </summary>
        public const string LIMKEY = "LIMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LILIBID", "LILIBID", JdeDataType.Numeric, null, true, true),
        new JdeField("LILIBNAME", "LILIBNAME", JdeDataType.String, 60),
        new JdeField("LILIBDESC", "LILIBDESC", JdeDataType.String, 508),
        new JdeField("LISETID", "LISETID", JdeDataType.String, 10),
        new JdeField("LIDFLTFLG", "LIDFLTFLG", JdeDataType.String, 2),
        new JdeField("LISEARCHBL", "LISEARCHBL", JdeDataType.String, 2),
        new JdeField("LIENTDBY", "LIENTDBY", JdeDataType.Numeric),
        new JdeField("LIEDATE", "LIEDATE", JdeDataType.Date),
        new JdeField("LIUSER", "LIUSER", JdeDataType.String, 20),
        new JdeField("LIUDTTM", "LIUDTTM", JdeDataType.Date),
        new JdeField("LIMKEY", "LIMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE02_0", "Primary Key on LILIBID", new[] { "LILIBID" }, isUnique: true, isPrimaryKey: true)
    };
}
