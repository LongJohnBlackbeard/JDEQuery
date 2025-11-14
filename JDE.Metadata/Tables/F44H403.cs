using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H403 - .
/// </summary>
public class F44H403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPHBAREA.
        /// </summary>
        public const string OPHBAREA = "OPHBAREA";

        /// <summary>
        /// OPHBMCUS.
        /// </summary>
        public const string OPHBMCUS = "OPHBMCUS";

        /// <summary>
        /// OPCPHASE.
        /// </summary>
        public const string OPCPHASE = "OPCPHASE";

        /// <summary>
        /// OPHBPLAN.
        /// </summary>
        public const string OPHBPLAN = "OPHBPLAN";

        /// <summary>
        /// OPOPM01.
        /// </summary>
        public const string OPOPM01 = "OPOPM01";

        /// <summary>
        /// OPOPM02.
        /// </summary>
        public const string OPOPM02 = "OPOPM02";

        /// <summary>
        /// OPOPM03.
        /// </summary>
        public const string OPOPM03 = "OPOPM03";

        /// <summary>
        /// OPOPTION.
        /// </summary>
        public const string OPOPTION = "OPOPTION";

        /// <summary>
        /// OPOPPLB.
        /// </summary>
        public const string OPOPPLB = "OPOPPLB";

        /// <summary>
        /// OPVALREQ.
        /// </summary>
        public const string OPVALREQ = "OPVALREQ";

        /// <summary>
        /// OPOPPRQ.
        /// </summary>
        public const string OPOPPRQ = "OPOPPRQ";

        /// <summary>
        /// OPCRTU.
        /// </summary>
        public const string OPCRTU = "OPCRTU";

        /// <summary>
        /// OPCRTJ.
        /// </summary>
        public const string OPCRTJ = "OPCRTJ";

        /// <summary>
        /// OPCRTT.
        /// </summary>
        public const string OPCRTT = "OPCRTT";

        /// <summary>
        /// OPWRKSTNID.
        /// </summary>
        public const string OPWRKSTNID = "OPWRKSTNID";

        /// <summary>
        /// OPHBOPID.
        /// </summary>
        public const string OPHBOPID = "OPHBOPID";

        /// <summary>
        /// OPUPMB.
        /// </summary>
        public const string OPUPMB = "OPUPMB";

        /// <summary>
        /// OPUPMJ.
        /// </summary>
        public const string OPUPMJ = "OPUPMJ";

        /// <summary>
        /// OPUPMT.
        /// </summary>
        public const string OPUPMT = "OPUPMT";

        /// <summary>
        /// OPJOBN.
        /// </summary>
        public const string OPJOBN = "OPJOBN";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPHBAREA", "OPHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("OPHBMCUS", "OPHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OPCPHASE", "OPCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("OPHBPLAN", "OPHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("OPOPM01", "OPOPM01", JdeDataType.String, 6, true, true),
        new JdeField("OPOPM02", "OPOPM02", JdeDataType.String, 6, true, true),
        new JdeField("OPOPM03", "OPOPM03", JdeDataType.String, 6, true, true),
        new JdeField("OPOPTION", "OPOPTION", JdeDataType.String, 16, true, true),
        new JdeField("OPOPPLB", "OPOPPLB", JdeDataType.String, 40, true, true),
        new JdeField("OPVALREQ", "OPVALREQ", JdeDataType.String, 2),
        new JdeField("OPOPPRQ", "OPOPPRQ", JdeDataType.String, 2),
        new JdeField("OPCRTU", "OPCRTU", JdeDataType.String, 20),
        new JdeField("OPCRTJ", "OPCRTJ", JdeDataType.Numeric),
        new JdeField("OPCRTT", "OPCRTT", JdeDataType.Numeric),
        new JdeField("OPWRKSTNID", "OPWRKSTNID", JdeDataType.String, 20),
        new JdeField("OPHBOPID", "OPHBOPID", JdeDataType.String, 20),
        new JdeField("OPUPMB", "OPUPMB", JdeDataType.String, 20),
        new JdeField("OPUPMJ", "OPUPMJ", JdeDataType.Numeric),
        new JdeField("OPUPMT", "OPUPMT", JdeDataType.Numeric),
        new JdeField("OPJOBN", "OPJOBN", JdeDataType.String, 20),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H403_0", "Primary Key on OPHBAREA, OPHBMCUS, OPCPHASE, OPHBPLAN, OPOPM01, OPOPM02, OPOPM03, OPOPTION, OPOPPLB", new[] { "OPHBAREA", "OPHBMCUS", "OPCPHASE", "OPHBPLAN", "OPOPM01", "OPOPM02", "OPOPM03", "OPOPTION", "OPOPPLB" }, isUnique: true, isPrimaryKey: true)
    };
}
