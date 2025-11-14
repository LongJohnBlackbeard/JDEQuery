using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H0920 - .
/// </summary>
public class F44H0920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STSDTYP.
        /// </summary>
        public const string STSDTYP = "STSDTYP";

        /// <summary>
        /// STSDKY.
        /// </summary>
        public const string STSDKY = "STSDKY";

        /// <summary>
        /// STHBAREA.
        /// </summary>
        public const string STHBAREA = "STHBAREA";

        /// <summary>
        /// STHBMCUS.
        /// </summary>
        public const string STHBMCUS = "STHBMCUS";

        /// <summary>
        /// STSDLIN.
        /// </summary>
        public const string STSDLIN = "STSDLIN";

        /// <summary>
        /// STSDDSC.
        /// </summary>
        public const string STSDDSC = "STSDDSC";

        /// <summary>
        /// STPRODM.
        /// </summary>
        public const string STPRODM = "STPRODM";

        /// <summary>
        /// STPRODF.
        /// </summary>
        public const string STPRODF = "STPRODF";

        /// <summary>
        /// STEDINACT.
        /// </summary>
        public const string STEDINACT = "STEDINACT";

        /// <summary>
        /// STCRTU.
        /// </summary>
        public const string STCRTU = "STCRTU";

        /// <summary>
        /// STCRTJ.
        /// </summary>
        public const string STCRTJ = "STCRTJ";

        /// <summary>
        /// STCRTT.
        /// </summary>
        public const string STCRTT = "STCRTT";

        /// <summary>
        /// STWRKSTNID.
        /// </summary>
        public const string STWRKSTNID = "STWRKSTNID";

        /// <summary>
        /// STHBOPID.
        /// </summary>
        public const string STHBOPID = "STHBOPID";

        /// <summary>
        /// STUPMB.
        /// </summary>
        public const string STUPMB = "STUPMB";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H0920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STSDTYP", "STSDTYP", JdeDataType.String, 6, true, true),
        new JdeField("STSDKY", "STSDKY", JdeDataType.String, 20, true, true),
        new JdeField("STHBAREA", "STHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("STHBMCUS", "STHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("STSDLIN", "STSDLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("STSDDSC", "STSDDSC", JdeDataType.String, 100),
        new JdeField("STPRODM", "STPRODM", JdeDataType.String, 16),
        new JdeField("STPRODF", "STPRODF", JdeDataType.String, 16),
        new JdeField("STEDINACT", "STEDINACT", JdeDataType.String, 2),
        new JdeField("STCRTU", "STCRTU", JdeDataType.String, 20),
        new JdeField("STCRTJ", "STCRTJ", JdeDataType.Numeric),
        new JdeField("STCRTT", "STCRTT", JdeDataType.Numeric),
        new JdeField("STWRKSTNID", "STWRKSTNID", JdeDataType.String, 20),
        new JdeField("STHBOPID", "STHBOPID", JdeDataType.String, 20),
        new JdeField("STUPMB", "STUPMB", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H0920_0", "Primary Key on STSDTYP, STSDKY, STHBAREA, STHBMCUS, STSDLIN", new[] { "STSDTYP", "STSDKY", "STHBAREA", "STHBMCUS", "STSDLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
