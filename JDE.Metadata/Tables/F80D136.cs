using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D136 - .
/// </summary>
public class F80D136 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDALERTDET.
        /// </summary>
        public const string SDALERTDET = "SDALERTDET";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDLL.
        /// </summary>
        public const string SDLL = "SDLL";

        /// <summary>
        /// SDGRID.
        /// </summary>
        public const string SDGRID = "SDGRID";

        /// <summary>
        /// SDAPPNID.
        /// </summary>
        public const string SDAPPNID = "SDAPPNID";

        /// <summary>
        /// SDTOROLE.
        /// </summary>
        public const string SDTOROLE = "SDTOROLE";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDMUSE.
        /// </summary>
        public const string SDMUSE = "SDMUSE";

        /// <summary>
        /// SDMKEY.
        /// </summary>
        public const string SDMKEY = "SDMKEY";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUUPMJ.
        /// </summary>
        public const string SDUUPMJ = "SDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D136";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDALERTDET", "SDALERTDET", JdeDataType.Numeric, null, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDLL", "SDLL", JdeDataType.String, 20),
        new JdeField("SDGRID", "SDGRID", JdeDataType.String, 40),
        new JdeField("SDAPPNID", "SDAPPNID", JdeDataType.String, 20),
        new JdeField("SDTOROLE", "SDTOROLE", JdeDataType.String, 30),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDMUSE", "SDMUSE", JdeDataType.String, 20),
        new JdeField("SDMKEY", "SDMKEY", JdeDataType.String, 30),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUUPMJ", "SDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D136_0", "Primary Key on SDALERTDET, SDLNID", new[] { "SDALERTDET", "SDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
