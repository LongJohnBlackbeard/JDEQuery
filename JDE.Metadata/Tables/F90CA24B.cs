using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA24B - .
/// </summary>
public class F90CA24B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATATCIDENT.
        /// </summary>
        public const string ATATCIDENT = "ATATCIDENT";

        /// <summary>
        /// ATATCTYPE.
        /// </summary>
        public const string ATATCTYPE = "ATATCTYPE";

        /// <summary>
        /// ATATCDATE.
        /// </summary>
        public const string ATATCDATE = "ATATCDATE";

        /// <summary>
        /// ATATCDPATH.
        /// </summary>
        public const string ATATCDPATH = "ATATCDPATH";

        /// <summary>
        /// ATATCFNAME.
        /// </summary>
        public const string ATATCFNAME = "ATATCFNAME";

        /// <summary>
        /// ATATCBSIZE.
        /// </summary>
        public const string ATATCBSIZE = "ATATCBSIZE";

        /// <summary>
        /// ATATCEBY.
        /// </summary>
        public const string ATATCEBY = "ATATCEBY";

        /// <summary>
        /// ATATCDENT.
        /// </summary>
        public const string ATATCDENT = "ATATCDENT";

        /// <summary>
        /// ATATCMODBY.
        /// </summary>
        public const string ATATCMODBY = "ATATCMODBY";

        /// <summary>
        /// ATATCDMOD.
        /// </summary>
        public const string ATATCDMOD = "ATATCDMOD";

        /// <summary>
        /// ATATCDESCR.
        /// </summary>
        public const string ATATCDESCR = "ATATCDESCR";

        /// <summary>
        /// ATATCDID.
        /// </summary>
        public const string ATATCDID = "ATATCDID";

        /// <summary>
        /// ATATCDTYPE.
        /// </summary>
        public const string ATATCDTYPE = "ATATCDTYPE";

        /// <summary>
        /// ATATCULINK.
        /// </summary>
        public const string ATATCULINK = "ATATCULINK";

        /// <summary>
        /// ATATCSUDTE.
        /// </summary>
        public const string ATATCSUDTE = "ATATCSUDTE";

        /// <summary>
        /// ATATCACIN.
        /// </summary>
        public const string ATATCACIN = "ATATCACIN";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA24B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATATCIDENT", "ATATCIDENT", JdeDataType.Numeric, null, true, true),
        new JdeField("ATATCTYPE", "ATATCTYPE", JdeDataType.String, 10),
        new JdeField("ATATCDATE", "ATATCDATE", JdeDataType.Numeric),
        new JdeField("ATATCDPATH", "ATATCDPATH", JdeDataType.String, 510),
        new JdeField("ATATCFNAME", "ATATCFNAME", JdeDataType.String, 510),
        new JdeField("ATATCBSIZE", "ATATCBSIZE", JdeDataType.Numeric),
        new JdeField("ATATCEBY", "ATATCEBY", JdeDataType.Numeric),
        new JdeField("ATATCDENT", "ATATCDENT", JdeDataType.Numeric),
        new JdeField("ATATCMODBY", "ATATCMODBY", JdeDataType.Numeric),
        new JdeField("ATATCDMOD", "ATATCDMOD", JdeDataType.Numeric),
        new JdeField("ATATCDESCR", "ATATCDESCR", JdeDataType.String, 3998),
        new JdeField("ATATCDID", "ATATCDID", JdeDataType.Numeric),
        new JdeField("ATATCDTYPE", "ATATCDTYPE", JdeDataType.String, 10),
        new JdeField("ATATCULINK", "ATATCULINK", JdeDataType.String, 510),
        new JdeField("ATATCSUDTE", "ATATCSUDTE", JdeDataType.Numeric),
        new JdeField("ATATCACIN", "ATATCACIN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA24B_0", "Primary Key on ATATCIDENT", new[] { "ATATCIDENT" }, isUnique: true, isPrimaryKey: true)
    };
}
