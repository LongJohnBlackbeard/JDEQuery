using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI003 - .
/// </summary>
public class F30UI003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WRLLX.
        /// </summary>
        public const string WRLLX = "WRLLX";

        /// <summary>
        /// WRINT01.
        /// </summary>
        public const string WRINT01 = "WRINT01";

        /// <summary>
        /// WRMMCU.
        /// </summary>
        public const string WRMMCU = "WRMMCU";

        /// <summary>
        /// WRITM.
        /// </summary>
        public const string WRITM = "WRITM";

        /// <summary>
        /// WRDOCO.
        /// </summary>
        public const string WRDOCO = "WRDOCO";

        /// <summary>
        /// WRLOCN.
        /// </summary>
        public const string WRLOCN = "WRLOCN";

        /// <summary>
        /// WRLOTN.
        /// </summary>
        public const string WRLOTN = "WRLOTN";

        /// <summary>
        /// WRLOCF.
        /// </summary>
        public const string WRLOCF = "WRLOCF";

        /// <summary>
        /// WRLOTF.
        /// </summary>
        public const string WRLOTF = "WRLOTF";

        /// <summary>
        /// WRDCTO.
        /// </summary>
        public const string WRDCTO = "WRDCTO";

        /// <summary>
        /// WRLITM.
        /// </summary>
        public const string WRLITM = "WRLITM";

        /// <summary>
        /// WRAITM.
        /// </summary>
        public const string WRAITM = "WRAITM";

        /// <summary>
        /// WRPART.
        /// </summary>
        public const string WRPART = "WRPART";

        /// <summary>
        /// WRUOM.
        /// </summary>
        public const string WRUOM = "WRUOM";

        /// <summary>
        /// WRGLPT.
        /// </summary>
        public const string WRGLPT = "WRGLPT";

        /// <summary>
        /// WRLEDG.
        /// </summary>
        public const string WRLEDG = "WRLEDG";

        /// <summary>
        /// WRSRST.
        /// </summary>
        public const string WRSRST = "WRSRST";

        /// <summary>
        /// WRPPFG.
        /// </summary>
        public const string WRPPFG = "WRPPFG";

        /// <summary>
        /// WREXPI.
        /// </summary>
        public const string WREXPI = "WREXPI";

        /// <summary>
        /// WREV01.
        /// </summary>
        public const string WREV01 = "WREV01";

        /// <summary>
        /// WRSTKT.
        /// </summary>
        public const string WRSTKT = "WRSTKT";

        /// <summary>
        /// WRUORG.
        /// </summary>
        public const string WRUORG = "WRUORG";

        /// <summary>
        /// WRCLEV.
        /// </summary>
        public const string WRCLEV = "WRCLEV";

        /// <summary>
        /// WRSOQS.
        /// </summary>
        public const string WRSOQS = "WRSOQS";

        /// <summary>
        /// WRSOCN.
        /// </summary>
        public const string WRSOCN = "WRSOCN";

        /// <summary>
        /// WRLGWK.
        /// </summary>
        public const string WRLGWK = "WRLGWK";

        /// <summary>
        /// WRDOCZ.
        /// </summary>
        public const string WRDOCZ = "WRDOCZ";

        /// <summary>
        /// WRERRC.
        /// </summary>
        public const string WRERRC = "WRERRC";

        /// <summary>
        /// WRUSER.
        /// </summary>
        public const string WRUSER = "WRUSER";

        /// <summary>
        /// WRPEID.
        /// </summary>
        public const string WRPEID = "WRPEID";

        /// <summary>
        /// WRJOBS.
        /// </summary>
        public const string WRJOBS = "WRJOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WRLLX", "WRLLX", JdeDataType.Numeric, null, true, true),
        new JdeField("WRINT01", "WRINT01", JdeDataType.Numeric, null, true, true),
        new JdeField("WRMMCU", "WRMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WRITM", "WRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WRDOCO", "WRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WRLOCN", "WRLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WRLOTN", "WRLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WRLOCF", "WRLOCF", JdeDataType.String, 40, true, true),
        new JdeField("WRLOTF", "WRLOTF", JdeDataType.String, 60, true, true),
        new JdeField("WRDCTO", "WRDCTO", JdeDataType.String, 4),
        new JdeField("WRLITM", "WRLITM", JdeDataType.String, 50),
        new JdeField("WRAITM", "WRAITM", JdeDataType.String, 50),
        new JdeField("WRPART", "WRPART", JdeDataType.String, 2),
        new JdeField("WRUOM", "WRUOM", JdeDataType.String, 4),
        new JdeField("WRGLPT", "WRGLPT", JdeDataType.String, 8),
        new JdeField("WRLEDG", "WRLEDG", JdeDataType.String, 4),
        new JdeField("WRSRST", "WRSRST", JdeDataType.String, 4),
        new JdeField("WRPPFG", "WRPPFG", JdeDataType.String, 2),
        new JdeField("WREXPI", "WREXPI", JdeDataType.String, 2),
        new JdeField("WREV01", "WREV01", JdeDataType.String, 2),
        new JdeField("WRSTKT", "WRSTKT", JdeDataType.String, 2),
        new JdeField("WRUORG", "WRUORG", JdeDataType.Numeric),
        new JdeField("WRCLEV", "WRCLEV", JdeDataType.String, 2),
        new JdeField("WRSOQS", "WRSOQS", JdeDataType.Numeric),
        new JdeField("WRSOCN", "WRSOCN", JdeDataType.Numeric),
        new JdeField("WRLGWK", "WRLGWK", JdeDataType.String, 4),
        new JdeField("WRDOCZ", "WRDOCZ", JdeDataType.Numeric),
        new JdeField("WRERRC", "WRERRC", JdeDataType.String, 2),
        new JdeField("WRUSER", "WRUSER", JdeDataType.String, 20, true, true),
        new JdeField("WRPEID", "WRPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("WRJOBS", "WRJOBS", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI003_0", "Primary Key on WRUSER, WRPEID, WRJOBS, WRLLX, WRINT01, WRMMCU, WRITM, WRDOCO, WRLOCN, WRLOTN, WRLOCF, WRLOTF", new[] { "WRUSER", "WRPEID", "WRJOBS", "WRLLX", "WRINT01", "WRMMCU", "WRITM", "WRDOCO", "WRLOCN", "WRLOTN", "WRLOCF", "WRLOTF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI003_2", "Index on WRUSER, WRPEID, WRJOBS, WRDOCO, WRPART", new[] { "WRUSER", "WRPEID", "WRJOBS", "WRDOCO", "WRPART" }),
        new JdeIndex("F30UI003_3", "Index on WRUSER, WRPEID, WRJOBS, WREXPI, WRDOCZ, WRPART", new[] { "WRUSER", "WRPEID", "WRJOBS", "WREXPI", "WRDOCZ", "WRPART" })
    };
}
