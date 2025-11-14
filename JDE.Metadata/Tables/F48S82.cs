using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S82 - .
/// </summary>
public class F48S82 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRUKID.
        /// </summary>
        public const string BRUKID = "BRUKID";

        /// <summary>
        /// BRSEGMID.
        /// </summary>
        public const string BRSEGMID = "BRSEGMID";

        /// <summary>
        /// BREFTB.
        /// </summary>
        public const string BREFTB = "BREFTB";

        /// <summary>
        /// BRBUCA.
        /// </summary>
        public const string BRBUCA = "BRBUCA";

        /// <summary>
        /// BRMCU.
        /// </summary>
        public const string BRMCU = "BRMCU";

        /// <summary>
        /// BRSTYL.
        /// </summary>
        public const string BRSTYL = "BRSTYL";

        /// <summary>
        /// BRDOCO.
        /// </summary>
        public const string BRDOCO = "BRDOCO";

        /// <summary>
        /// BRDCTO.
        /// </summary>
        public const string BRDCTO = "BRDCTO";

        /// <summary>
        /// BRKCOO.
        /// </summary>
        public const string BRKCOO = "BRKCOO";

        /// <summary>
        /// BROBJ.
        /// </summary>
        public const string BROBJ = "BROBJ";

        /// <summary>
        /// BROBJT.
        /// </summary>
        public const string BROBJT = "BROBJT";

        /// <summary>
        /// BRSUB.
        /// </summary>
        public const string BRSUB = "BRSUB";

        /// <summary>
        /// BRSUBT.
        /// </summary>
        public const string BRSUBT = "BRSUBT";

        /// <summary>
        /// BRBCOM.
        /// </summary>
        public const string BRBCOM = "BRBCOM";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRUPMT.
        /// </summary>
        public const string BRUPMT = "BRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S82";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRUKID", "BRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BRSEGMID", "BRSEGMID", JdeDataType.String, 6),
        new JdeField("BREFTB", "BREFTB", JdeDataType.Numeric),
        new JdeField("BRBUCA", "BRBUCA", JdeDataType.String, 10),
        new JdeField("BRMCU", "BRMCU", JdeDataType.String, 24),
        new JdeField("BRSTYL", "BRSTYL", JdeDataType.String, 4),
        new JdeField("BRDOCO", "BRDOCO", JdeDataType.Numeric),
        new JdeField("BRDCTO", "BRDCTO", JdeDataType.String, 4),
        new JdeField("BRKCOO", "BRKCOO", JdeDataType.String, 10),
        new JdeField("BROBJ", "BROBJ", JdeDataType.String, 12),
        new JdeField("BROBJT", "BROBJT", JdeDataType.String, 12),
        new JdeField("BRSUB", "BRSUB", JdeDataType.String, 16),
        new JdeField("BRSUBT", "BRSUBT", JdeDataType.String, 16),
        new JdeField("BRBCOM", "BRBCOM", JdeDataType.String, 6),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRUPMT", "BRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S82_0", "Primary Key on BRUKID", new[] { "BRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S82_2", "Index on BRSEGMID, BREFTB, BRBUCA", new[] { "BRSEGMID", "BREFTB", "BRBUCA" }),
        new JdeIndex("F48S82_3", "Index on BRSEGMID, BREFTB, BRBUCA, BRMCU, BRDOCO, BRDCTO, BRKCOO, BRSTYL, BROBJ, BROBJT, BRSUB, BRSUBT", new[] { "BRSEGMID", "BREFTB", "BRBUCA", "BRMCU", "BRDOCO", "BRDCTO", "BRKCOO", "BRSTYL", "BROBJ", "BROBJT", "BRSUB", "BRSUBT" })
    };
}
